using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsCali
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static bool LoginAdmin(string user, string pass) =>
            user == "jromero" && pass == "prueba00" ? true : false;

        public static bool LogInStudent(string user, string pass) =>
            user == "2" && pass == "Password00" ? true : false;

        public static bool LogInDocente(string user, string pass) =>
            user == "7" && pass == "Password00" ? true : false;


        public static int Calificacion(int nota, string notaletra)
        {
            nota = 90;
            if (nota >= 90)
            {
                notaletra = "A";
            }

            if (nota >= 80)
            {
                notaletra = "B";
            }
            if (nota >= 85)
            {
                notaletra = "B+";
            }
            if (nota >= 75)
            {
                notaletra = "C+";
            }
            if (nota >= 70)
            {
                notaletra = "C";
            }
            if (nota >= 65)
            {
                notaletra = "D";
                if (nota <= 60)
                {
                    notaletra = "F";
                }
            }
            return 0;
        }
            public static string conseguirHonores(double indice)
            {
                if (indice >= 3.8)
                {
                    return "Summa Cum Laude";
                }
                else if (indice >= 3.5)
                {
                    return "Magna Cum Laude";
                }
                else if (indice >= 3.2)
                {
                    return "Cum Laude";
                }
                else
                {
                    return "Sin honor";
                }


            }

        }


    }

    

