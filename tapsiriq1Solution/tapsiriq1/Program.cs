using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq1
{
    class Program 
    {
        static void Main(string[] args)
        {
            int crdId;
            int slr;
            int clntId;
            int phn;
            int prc;
            int cnt;
            string selection;
            Employee employe1 = new Employee();
            Client client1 = new Client();
            Product product1 = new Product();
            Order order1 = new Order();

            do
                    {
                Console.WriteLine("Secim edin :");
                Console.WriteLine("I-ishci yaratmaq");
                Console.WriteLine("M-Musteri yaratmaq");
                Console.WriteLine("P-Mehsul yaratmaq");
                Console.WriteLine("O-Sifaris yaratmaq");
                selection = Console.ReadLine();

                switch (selection)
                {

                    case "i":
                    case "I":
                        
                        Console.WriteLine("Isci yaratmaq ucun suallari cavablandirin: ");
                        Console.WriteLine("Adiniz :");
                        employe1.setName(Console.ReadLine());
                        Console.WriteLine("Soyadiniz :");
                        employe1.setSurname(Console.ReadLine());
                        Console.WriteLine("Dogum ilinizi daxil edin : ");
                        employe1.Birthday = Console.ReadLine();
                        Console.WriteLine("Kart ID-iz :");
                        Int32.TryParse(Console.ReadLine(), out crdId);
                        employe1.setCardId(crdId);
                        Console.WriteLine("Vezifeniz :");
                        employe1.setPosition(Console.ReadLine());
                        Console.WriteLine("Maasiniz : ");
                        Int32.TryParse(Console.ReadLine(), out slr);
                        employe1.setSalary(slr);
                        Console.WriteLine("Isci yaradildi. {0} - {1} {2} {3} yas", employe1.getId(), employe1.getName(), employe1.getSurname(), employe1.Birthday);
                        Console.ReadLine();
                        break;
                    case "m":
                    case "M":
                        
                        Console.WriteLine("Musteri yaratmaq ucun suallari cavablandirin: ");
                        Console.WriteLine("Adiniz :");
                        client1.setName(Console.ReadLine());
                        Console.WriteLine("Soyadiniz :");
                        client1.setSurname(Console.ReadLine());
                        Console.WriteLine("Dogum ilinizi daxil edin : ");
                        client1.Birthday = Console.ReadLine();
                        Console.WriteLine("Kart ID-iz :");
                        Int32.TryParse(Console.ReadLine(), out crdId);
                        client1.setCardId(crdId);
                        Console.WriteLine("Musteri ID-nizi daxil edin : ");
                        Int32.TryParse(Console.ReadLine(), out clntId);
                        client1.setClientId(clntId);
                        Console.WriteLine("Addresinizi daxil edin : ");
                        client1.setAddress(Console.ReadLine());
                        Console.WriteLine("Nomrenizi daxil edin : ");
                        Int32.TryParse(Console.ReadLine(), out phn);
                        client1.setPhone(phn);
                        Console.WriteLine("{0} - Musteri yaradildi. {0} - {1} {2}", client1.getId(), client1.getName(), client1.getSurname());
                        Console.ReadLine();
                        break;
                    case "p":
                    case "P":
                        
                        Console.WriteLine("Mehsul yaratmaq ucun suallari cavablandirin :");
                        Console.WriteLine("Adi :");
                        product1.setName(Console.ReadLine());
                        Console.WriteLine("Rengi");
                        product1.setColor(Console.ReadLine());
                        Console.WriteLine("Qiymeti :");
                        Int32.TryParse(Console.ReadLine(), out prc);
                        product1.setPrice(prc);
                        Console.WriteLine(" Mehsul yaradildi. {0} - {1} {2} {3}$", product1.getId(), product1.getName(), product1.getColor(), product1.getPrice());


                        Console.ReadLine();



                        break;
                    case "o":
                    case "O":
                        
                       
                        

                        Console.WriteLine("Sifaris yaratmaq ucun suallari cavablandirin :");
                        Console.WriteLine("Sayi :");
                        Int32.TryParse(Console.ReadLine(), out cnt);
                        order1.setCount(cnt);
                        Console.WriteLine("Sifaris yaradildi: {0} - {1} {2} terefinden sifaris olundu. Sayi : {3}, Cemi Mebleg : {4}." +
                            "Sifarisi qebul eden isci : {5} {6} {7}.", order1.getId(), client1.getName(), client1.getSurname(), order1.getCount(),  order1.TotalPrice(order1.getCount(), product1.getPrice()), employe1.getName(), employe1.getSurname(), employe1.getPosition());
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Dogru secim etmemisiniz");

                        break;
                }
                } while (selection != "i" || selection != "I" || selection != "m" || selection != "M" || selection != "p" || selection != "P"
        || selection != "o" || selection != "O");
            
        }
    }
}
