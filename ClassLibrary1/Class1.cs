using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class NewsArticle
    {
        public string Title;
        public string Category;

        public NewsArticle(string title, string category)
        {
            Title = title; 
            Category = category; 
        }

    }

    public class NewsArticleCollection
    {

       public List<NewsArticle> articles = new List<NewsArticle>();


        public void AddArticle(NewsArticle article)
        {          
            articles.Add(article);
            //ArticleAdded();
        }

        public void RemoveArticle(NewsArticle article)
        {
            articles.Remove(article);
        }

        public void FilterArticlesByCategory(string category)
        {

            foreach(NewsArticle itObj in articles)
            {
                if (itObj.Category == category)
                {

                    Console.WriteLine(itObj.Title + ", " + itObj.Category);
                }
            }
        }
        //a delegate that is invoked when a new article is added to the collection
        public delegate void articleAddedHandler();
 
        public void ArticleAdded()
        {
            Console.WriteLine("Article was added");
        }
    }

}
