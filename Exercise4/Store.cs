using System;
using System.Collections.Generic;
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

        public Article GetArticleByProductName(string name)
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
