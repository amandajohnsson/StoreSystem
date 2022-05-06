using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using LumenWorks.Framework.IO.Csv;

namespace StoreSystem
{
    public class ProductHandler
    {
       
        internal List<Product> Products { get; set; } = new List<Product>();
        internal List<string> SoldProducts { get; set; } = new List<string>();

        internal void LoadDatabase()
        {
            //LoadAPI();
            LoadDatabase("ProductDB.csv");

            
        }
 

        internal void LoadDatabase(string dbFilePath)
        {
            var allLines = File.ReadAllLines(dbFilePath);

            foreach (var line in allLines)
            {
                var lineElements = line.Split(',');

                switch (lineElements.First())
                {
                    case "Book":
                        Products.Add(ParseBook(lineElements));
                        break;
                    case "Game":
                        Products.Add(ParseGame(lineElements));
                        break;
                    case "Movie":
                        Products.Add(ParseMovie(lineElements));
                        break;
                    default:
                        throw new Exception("Oh no! Something is wrong!");
                        break;
                }
            }
        }
        internal void LoadAPI()
        {                   
            try
            {
                using (WebClient webClient = new WebClient())
                {                  
                    var text = webClient.DownloadString("https://hex.cse.kau.se/~jonavest/csharp-api/");
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(text);
                    foreach (XmlElement el in doc.FirstChild.ChildNodes)
                    {
                        if (el.Name == "products")
                        {
                            foreach (XmlNode node in el.ChildNodes)
                            {
                                List<string> myList = new List<string>();

                                myList.Add(node.Name);
                                foreach (XmlNode nodeChild in node.ChildNodes)
                                    myList.Add(nodeChild.InnerText);
                                if (node.Name == "book")
                                    myList.ToArray();
                                    Products.Add(ParseBook(myList.ToArray()));
                                //Console.WriteLine(myList);                           
                            }
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }
        internal void WriteToDB(string dbFilePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("ProductDB.csv"))
                {
                    foreach (Product product in Products)
                    {
                        sw.WriteLine(ProductToFileformat(product));
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string ProductToFileformat(Product product)
        {
            switch( product )
            {
                case Book b:
                    return ConvertBookToFileformat(b);
                    break;
                case Game g:
                    return ConvertGameToFileformat(g);
                    break;
                case Movie m:
                    return ConvertMovieToFileformat(m);
                    break;
                case null:
                    throw new ArgumentException(nameof(product));

            }
            return null;
        }

        private string ConvertBookToFileformat(Book book)
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}"
                , book.ProductCategory.ToString()
                , book.Quantity.ToString()
                , book.ID.ToString()
                , book.Name.ToString()
                , book.Price.ToString()
                , book.Author.ToString()
                , book.Genre.ToString()
                , book.FormatBook.ToString()
                , book.Language.ToString());


        }
        private string ConvertGameToFileformat(Game game)
        {
            return string.Format("{0},{1},{2},{3},{4},{5}"
                , game.ProductCategory.ToString()
                , game.Quantity.ToString()
                , game.ID.ToString()
                , game.Name.ToString()
                , game.Price.ToString()
                , game.Platform.ToString());

        }
        private string ConvertMovieToFileformat(Movie movie)
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6}"
                , movie.ProductCategory.ToString()
                , movie.Quantity.ToString()
                , movie.ID.ToString()
                , movie.Name.ToString()
                , movie.Price.ToString()
                , movie.FormatMovie.ToString()
                , movie.Playtime.ToString());

        }

        private Book ParseBook(string[] lineElements)
        {
            return new Book
            {
                ProductCategory = (ProductCategory)Enum.Parse(typeof(ProductCategory), lineElements[0], true),
                Quantity = lineElements[1],
                ID = lineElements[2],
                Name = lineElements[3],
                Price = double.Parse(lineElements[4]),
                Author = lineElements[5],
                Genre = (Genre)Enum.Parse(typeof(Genre), lineElements[6], true),
                FormatBook = (FormatBook)Enum.Parse(typeof(FormatBook), lineElements[7], true),
                Language = lineElements[8],

            };
        }
        private Game ParseGame(string[] lineElements)
        {
            return new Game
            {
                ProductCategory = (ProductCategory)Enum.Parse(typeof(ProductCategory), lineElements[0], true),
                Quantity = lineElements[1],
                ID = lineElements[2],
                Name = lineElements[3],
                Price = double.Parse(lineElements[4].Replace(".", ",")),
                Platform = (Platform)Enum.Parse(typeof(Platform), lineElements[5], true),
            };
        }

        private Movie ParseMovie(string[] lineElements)
        {
            return new Movie
            {
                ProductCategory = (ProductCategory)Enum.Parse(typeof(ProductCategory), lineElements[0], true),
                Quantity = lineElements[1],
                ID = lineElements[2],
                Name = lineElements[3],
                Price = double.Parse(lineElements[4].Replace(".", ",")),
                FormatMovie = (FormatMovie)Enum.Parse(typeof(FormatMovie), lineElements[5], true),
                Playtime = lineElements[6],
            };
        }

        internal void changeQuantity(string ID, string op)
        {
            float quantity;
            foreach(Product product in Products)
            {
                if(product.ID == ID)
                {
                    quantity = float.Parse(product.Quantity);
                    if(op == "add")
                        product.Quantity =  (quantity + 1).ToString();
                    else if(op == "remove")
                        product.Quantity = (quantity - 1).ToString();

                }
            }

        }

        internal void WritepurchaseDB()
        {

        }
        internal void savePurchase(string purchase)
        {
            SoldProducts.Add(purchase);
        }
        internal void LoadSoldProducts()
        {
            var allLines = File.ReadAllLines("SoldProducts.txt");

            foreach (var line in allLines)
            {
                var lineElements = line.Split(',');
                

                switch (lineElements.First())
                {
                    case "Book":
                        Products.Add(ParseBook(lineElements));
                        break;
                    case "Game":
                        Products.Add(ParseGame(lineElements));
                        break;
                    case "Movie":
                        Products.Add(ParseMovie(lineElements));
                        break;
                    default:
                        throw new Exception("Oh no! Something is wrong!");
                        break;
                }
            }
        }
        internal Product AddNewProduct(string  newProduct)
        {
            var newProductElements = newProduct.Split(',');

            switch (newProductElements.First())
            {
                case "Book":
                    return ParseBook(newProductElements);
                    break;
                case "Game":
                    return ParseGame(newProductElements);
                    break;
                case "Movie":
                    return ParseMovie(newProductElements);
                    break;
                default:
                    throw new Exception("Oh no! Something is wrong!");
                    break;
            }
        }
        internal List<Product> FilterGrid(string ID, string Name)
        {
            List<Product> FilterdProducts = new List<Product>();
            foreach (Product product in Products)
            {
                if (ID != null && Name != null)
                {
                    if (product.ID == ID && product.Name == Name)
                        FilterdProducts.Add(product);

                }
                else if(ID == null && Name != null)
                {
                    if (product.Name == Name)
                        FilterdProducts.Add(product);
                }
                else if(ID != null && Name == null)
                {
                    if(product.ID == ID)
                        FilterdProducts.Add(product);
                }
            }
            return FilterdProducts;
        }
    }

}
