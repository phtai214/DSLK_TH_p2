using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLK_TH_p2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            list.Input();

            while (true)
            {
                Console.Write("Moi chon menu: ");
                int choice;
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {

                    case 1:
                        {
                            Console.Write("Nhap vi tri thu i can xoa: ");
                            int i;
                            int.TryParse(Console.ReadLine(), out i);
                            if (i >= 0 && i < list.Count)
                            {
                                IntNode node = list.RemoveAt(i);
                                Console.WriteLine("Xoa thanh cong node co gia tri: {0}", node.Data);
                                list.ShowList();
                            }
                            else
                            {
                                Console.WriteLine("Vi tri i khong ton tai!");
                            }
                            break;
                        }


                    case 2:
                        {
                            Console.Write("Nhap gia tri x can xoa: ");
                            int x;
                            int.TryParse(Console.ReadLine(), out x);
                            list.RemoveX(x);
                            list.ShowList();
                            break;

                        }


                    case 3:

                        {
                            Console.Write("Nhap gia tri x: ");
                            int x;
                            int.TryParse(Console.ReadLine(), out x);
                            Console.Write("Nhap gia tri i: ");
                            int i;
                            int.TryParse(Console.ReadLine(), out i);

                            if (i >= 0 && i < list.Count)
                            {
                                list.InsertAt(x, i);
                                list.ShowList();
                            }
                            else
                            {
                                Console.WriteLine("Vi tri i khong ton tai!");
                            }
                            break;
                        }
                       
                       
                    case 4:
                        {
                            Console.Write("Nhap gia tri x: ");
                            int x;
                            int.TryParse(Console.ReadLine(), out x);
                            list.InsertXAfterMin(x);
                            Console.WriteLine("Danh sach sau khi chen");
                            list.ShowList();
                            break;
                        }


                    case 5:
                        {
                            Console.Write("Nhap gia tri x: ");
                            int x;
                            int.TryParse(Console.ReadLine(), out x);
                            Console.Write("Nhap gia tri y: ");
                            int y;
                            int.TryParse(Console.ReadLine(), out y);
                            list.InsertXAfterY(x, y);
                            Console.WriteLine("Danh sach sau khi chen");
                            list.ShowList();
                            break;
                        }
                       

                    case 6:
                        {
                            Console.Write("Nhap gia tri x: ");
                            int x;
                            int.TryParse(Console.ReadLine(), out x);
                            list.InsertXBeforeMax(x);
                            Console.WriteLine("Danh sach sau khi chen");
                            list.ShowList();
                            break;
                        }
                       

                    case 7:
                        {
                            Console.Write("Nhap gia tri x: ");
                            int x;
                            int.TryParse(Console.ReadLine(), out x);
                            Console.Write("Nhap gia tri y: ");
                            int y;
                            int.TryParse(Console.ReadLine(), out y);
                            list.InsertXBeforeY(x, y);
                            Console.WriteLine("Danh sach sau khi chen");
                            list.ShowList();
                            break;
                        }
                       

                    case 8:
                        {                        
                            list = list.RShiftRight();
                            Console.WriteLine("Danh sach sau khi dich sang phai:");
                            list.ShowList();
                            break;
                        }
                      

                    case 9:
                        {
                            list.InterchangeSort();
                            Console.WriteLine("Danh sach sau khi sap xep tang dan:");
                            list.ShowList();
                            break;
                        }
                        

                    case 10:
                        {
                            list.SelectionSort();
                            Console.WriteLine("Danh sach sau khi sap xep giam dan:");
                            list.ShowList();
                            break;
                        }
                       

                    case 0:
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long chon lai!");
                        break;

                }
            }
        }
    }
}
