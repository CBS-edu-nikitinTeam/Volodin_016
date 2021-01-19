using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Exercise4
{
    class Store
    {
        private Article[] _articles;

        public Store(int articeSize)
        {
            _articles = new Article[articeSize];
        }


        public Article this[int index]
        {
            get
            {
                return _articles[index];
            }
            set
            {
                _articles[index] = value;
            }
        }

        public Article this[string name]
        {
            // Через индексатор, вроде и проще и красивее.
            get
            {
                foreach (var article in _articles)
                {
                    if (article.ProductName.ToLower()
                        .Equals(name.ToLower()))
                    {
                        return article;
                    }
                }
                return null;
            }
        }

        public Article GetArticleByProductName(string name) // А почему не через индексатор?
        {
            Article result = null;

            foreach (var article in _articles)
            {
                if (article.ProductName.ToLower()
                    .Equals(name.ToLower()))
                {
                    result = article;
                    break;
                }
            }

            return result;
        }
    }
}
