using System;

namespace Act2
{
    class Program
    {
        static void Main(string[] args)
        {//Begin

            // Numeric nilM, nilB, rerata
            double nilM, nilB, rerata;

            // Character status
            string status;


            // Display 'Masukkan Nilai Matematika ='
            Console.Write("Masukkan Nilai Matematika= ");

            // Accept nilM
            nilM = Convert.ToDouble(Console.ReadLine());

            // Display 'Masukkan Nilai Bahasa Inggris ='
            Console.Write("Masukkan Nilai Bahasa Inggris= ");

            // Accept nilB
            nilB = Convert.ToDouble(Console.ReadLine());

            // Compute rerata = (nilM + nilB) / 2
            rerata = (nilM + nilB) / 2;

            // if (rerata >= 60 AND nilM >= 70)
            if (rerata >= 60 && nilM >= 70)
                //Begin

                    // status = 'lulus'
                    status = "lulus";
                //End

            // Else
            else
                //Begin

                    // status = 'gagal'
                    status = "gagal";
;;            //End
            // Display 'Status peserta adalah' + status
            Console.WriteLine("Status peserta adalah {0}", status);
            Console.ReadKey();
        }//End
    }
}
