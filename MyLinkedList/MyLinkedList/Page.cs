namespace MyLinkedLists
{
    public class Page
    {
        //What is actually needed on a page
        public string Content { set; get; } = string.Empty;
        //public int pageNumber { set; get; }
       

        public Page(string Content)
        {
            this.Content = Content;
            //pageNumber++;

        }
   
    }
}


