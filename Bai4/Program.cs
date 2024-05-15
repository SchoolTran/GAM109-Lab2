using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        // Phương thức kiểm tra số nguyên tố 
        public static bool check (int numberList)
        {
            if (numberList <= 1) return false;
            for (int i = 2; i < numberList; i++) 
            {
                if (numberList % i == 0)
                {
                    return false;
                };
            }
            return true;
        }

        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();

            // Thêm giá trị vào List 
            numberList.Add(10);
            numberList.Add(20);
            numberList.Add(30);
            numberList.Add(40);
            numberList.Add(50);

            // Câu 1: Hiển thị danh sách các số nguyên 
            Console.WriteLine("Cau 1: Danh sach so nguyen trong List: ");
            foreach (int i in numberList)
            {
                Console.WriteLine(i+ " ");
            }

            // Câu 2: Tính tổng các số nguyên có trong danh sách 
            int tong1 = 0;
            foreach (int i in numberList)
            {
                tong1 += i;
            }
            Console.WriteLine("Cau2: Tong cac so nguyen: " + tong1);

            // Câu 3: Tính tổng các số nguyên tố có trong danh sách 
            int tong2 = 0;
            foreach (int i in numberList)
            {
                if (check(i))
                {
                    tong2 += i;
                }
            }
            Console.WriteLine("Cau 3: Tong cac so nguyen to: " + tong2);

            // Yêu cầu 4. Tính tổng các số chẵn và vị trí lẻ trong danh sách
            int tong3 = 0;
            for (int i = 0; i < numberList.Count; i++) // numberList.Count là số lượng phần tử có trong List 
            {
                // nếu vị trí phần tử chia 2 dư "và" giá trị phần tử chia hết cho 2
                if (i % 2 > 0 && numberList[i] % 2 == 0) 
                    tong3 += numberList[i];
            }
            Console.WriteLine("Cau 4: Tong cac so chan o vi tri le: " + tong3);
            Console.ReadKey();
        }
    }
}
