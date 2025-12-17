using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Bước 1: Khai báo biến
        int nam;
        bool laNamNhuan = false;

        // Bước 2: Nhập dữ liệu từ bàn phím
        Console.Write("Nhập vào một năm: ");
        nam = Convert.ToInt32(Console.ReadLine());

        // Bước 3: Phân loại và kiểm tra năm nhuận
        bool chiaHetCho4 = nam % 4 == 0;

        if (chiaHetCho4)
        {
            bool chiaHetCho100 = nam % 100 == 0;

            if (chiaHetCho100)
            {
                bool chiaHetCho400 = nam % 400 == 0;

                if (chiaHetCho400)
                {
                    laNamNhuan = true;
                }
            }
            else
            {
                laNamNhuan = true;
            }
        }

        // Bước 4: Hiển thị kết quả
        if (laNamNhuan)
        {
            Console.WriteLine("{0} là năm nhuận", nam);
        }
        else
        {
            Console.WriteLine("{0} không phải là năm nhuận", nam);
        }
    }
}
