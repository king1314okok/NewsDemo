using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Web
    {
        private int id;
        private string newsUrl;
        private string title;
        private string url;
        private string content;
        private string picUrl;
        private int dateYM;
        private Editor pageEditor = new Editor();

        public string NewsUrl
        {
            get
            {
                return newsUrl;
            }

            set
            {
                newsUrl = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
            }
        }

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }

        public string PicUrl
        {
            get
            {
                return picUrl;
            }

            set
            {
                picUrl = value;
            }
        }

        public int DateYM
        {
            get
            {
                return dateYM;
            }

            set
            {
                dateYM = value;
            }
        }

        public Editor PageEditor
        {
            get
            {
                return pageEditor;
            }

            set
            {
                pageEditor = value;
            }
        }

        public Web()
        {

        }

        public Web(string url)
        {
            this.NewsUrl = url;
        }

        public Web(int id)
        {
            this.id = id;
        }
    }

    public class Editor
    {
        private string ename;
        private int eid;

        public string Ename
        {
            get
            {
                return ename;
            }

            set
            {
                ename = value;
            }
        }

        public int Eid
        {
            get
            {
                return eid;
            }

            set
            {
                eid = value;
            }
        }
    }
}
