using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsCali;

namespace IndiceAcademicoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Validate_Login_Admin_Authentication_True()
        {
            bool LogIn = WindowsCali.Program.LoginAdmin("jromero", "prueba00");
            Assert.AreEqual(true, LogIn);
        }

        [TestMethod]
        public void Validate_Login_Estudiante_Authentication_True()
        {
            bool LogIn = WindowsCali.Program.LogInStudent("2", "Password00");
            Assert.AreEqual(true, LogIn);
        }

        [TestMethod]
        public void Validate_Login_Docente_Authentication_True()
        {
            bool LogIn = WindowsCali.Program.LogInDocente("7", "Password00");
            Assert.AreEqual(true, LogIn);
        }

        [TestMethod]
        public void Validate_calification_over_90_A()
        {
            int nota = WindowsCali.Program.Calificacion(90, "A");
            Assert.AreEqual(0,nota);
        }

        [TestMethod]
        public void Validate_calification_over_85_Bplus()
        {
            int nota = WindowsCali.Program.Calificacion(85, "B+");
            Assert.AreEqual(0, nota);
        }

        [TestMethod]
        public void Validate_calification_over_80_B()
        {
            int nota = WindowsCali.Program.Calificacion(80, "B");
            Assert.AreEqual(0, nota);
        }

        [TestMethod]
        public void Validate_calification_over_75_Cplus()
        {
            int nota = WindowsCali.Program.Calificacion(75, "C+");
            Assert.AreEqual(0, nota);
        }
        [TestMethod]
        public void Validate_calification_over_70_C()
        {
            int nota = WindowsCali.Program.Calificacion(70, "C");
            Assert.AreEqual(0, nota);
        }
        [TestMethod]
        public void Validate_calification_over_65_D()
        {
            int nota = WindowsCali.Program.Calificacion(65, "D");
            Assert.AreEqual(0, nota);
        }

        [TestMethod]
        public void Validate_calification_over_60_or_less_F()
        {
            int nota = WindowsCali.Program.Calificacion(60, "F");
            Assert.AreEqual(0, nota);
        }
        [TestMethod]
        public void Validate_calification_over_60_or_less_F_grade()
        {
            int nota = WindowsCali.Program.Calificacion(50, "F");
            Assert.AreEqual(0, nota);
        }
        [TestMethod]
        public void indice_mayor_o_igual_a_3_punto_8()
        {
            string honores = WindowsCali.Program.conseguirHonores(3.9);
            Assert.AreEqual("Summa Cum Laude", honores);
        }
        [TestMethod]
        public void indice_mayor_o_igual_a_3_punto_5()
        {
            string honores = WindowsCali.Program.conseguirHonores(3.5);
            Assert.AreEqual("Magna Cum Laude", honores);
        }
        [TestMethod]
        public void indice_mayor_o_igual_a_3_punto_2()
        {
            string honores = WindowsCali.Program.conseguirHonores(3.3);
            Assert.AreEqual("Cum Laude", honores);
        }
        [TestMethod]
        public void indice_menor_a_3_punto_2()
        {
            string honores = WindowsCali.Program.conseguirHonores(3);
            Assert.AreEqual("Sin honor", honores);
        }
    }
}
