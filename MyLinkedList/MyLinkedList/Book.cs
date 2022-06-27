

namespace MyLinkedLists
{
    public class Book
    {
        private string Title, Author;
        int Year, pageNumber;
        //Page existPage;
        LinkedListNode<Page> bookPages;
        private LinkedList<Page> pages;
        LinkedListNode<Page> holdingNode;

        public Book(string Title, string Author, int Year)
        {
            this.Title = Title;
            this.Author = Author;
            this.Year = Year; 
            pages = new LinkedList<Page>();
           
            
        }

        public void DisplayBook()
        {
            Console.Write("Welcome to : " + Title + "\n");
            Console.Write("Author: " + Author + "\n");
            Console.WriteLine("Year created: " + Year + "\n");
        }

        public void addPages(Page[] bookPages)
        {
            foreach(Page p in bookPages)
            {
                pages.AddLast(p);
                
            }
        }


        public void selectDir(char dir,LinkedListNode<Page> node)
        {
            
             
            LinkedList<Page> current = new LinkedList<Page>();
            
            // = existPage.getFirstPage();// new LinkedList<LinkedListNode<Page>>();
            
            switch (dir)
            {
                case 'N' or 'n':
                    {
                        if (holdingNode != node)
                        {
                            //Try display first page
                            holdingNode = node;
                            pageNumber++;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
                        }else if(holdingNode == node)
                        {
                            holdingNode = node.Next;
                            pageNumber++;
                        }else if(holdingNode.Next == null)
                        {

                        }
             
                    }
                    break;

                case 'P' or 'p':
                    {
                        if (holdingNode != node)
                        {
                            //Try display first page
                            holdingNode = node.Previous;
                            pageNumber--;

                        }
                        else if (holdingNode == node && holdingNode.Previous == null)
                        {
                            
                        }
                        
                    }
                    break;
            }

            DisplayStyle(holdingNode);

        }

        private void DisplayStyle(LinkedListNode<Page> bookPage)
        {
            Console.WriteLine("-----------" + pageNumber + "----------\n");
            Console.WriteLine(holdingNode.Value.Content);
        }

    }
}
