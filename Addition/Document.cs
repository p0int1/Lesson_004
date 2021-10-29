using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    class Document
    {
        PartDoc title, body, footer;

        public Document(string docTitle)
        {
            title = new Title();
            body = new Body();
            footer = new Footer();

            title.Content = docTitle;
        }

        public void Show()
        {
            title.Show();
            body.Show();
            footer.Show();
        }

        public string Body
        {
            set
            {
                body.Content = value;
            }
        }

        public string Footer
        {
            set
            {
                footer.Content = value;
            }
        }

    }
}
