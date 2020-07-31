using System.Collections.Generic;
using Datos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq.Expressions;
System.Collections.dll
using System.Linq;
using System.Collections;

namespace UTDatos
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Raiz r = new Raiz();
            r.Otro = new Class2();
            r.Otro.Tercero = new Class3();

            Assert.IsNotNull(r);
            Assert.IsNotNull(r.Otro);
            Assert.IsNotNull(r.Otro.Tercero);
        }



        [TestMethod]

        public void TestListVarios()
        {
            IList<string> listaDeEjemplo = new List<string>();
            IList otraLista = new List<object>();

            otraLista.Add("Hola");
            otraLista.Add(new Raiz());

            object a = "Hola";
            a = new Raiz();
            string hola = (string)a;

            listaDeEjemplo.Add("Mensaje");

            string todos = "";
            for (int i = 0; i < listaDeEjemplo.Count; i++)
            {
                string mensajes = listaDeEjemplo[i];
                todos += mensajes;
            }

            todos = "";
            foreach (string mensajes in listaDeEjemplo)
            {
                todos += mensajes;
            }

            string primero = listaDeEjemplo.Select(x => x.Trim()).Where(x => x.StartsWith("Mensaje")).First();

        }

        [TestMethod]

        public void TestSet()
        {

            HashSet<string> miConjunto = new HashSet<string>();
            // Mala práctica miConjunto.EnsureCapacity(5)


            string cadena1 = new string("Mensaje");
            string cadena2 = new string("Mensaje");
            miConjunto.Add(cadena1);

            Assert.IsTrue(miConjunto.Contains(cadena2));

            ISet<object> miConjunto2 = new HashSet<object>();

            Raiz raiz1 = new Raiz();
            Raiz raiz2 = new Raiz();

            miConjunto2.Add(raiz1);

            Assert.IsTrue(miConjunto2.Contains(raiz2));


        }

        Dictionary<string, string> usuarioYEdad = new Dictionary<string, string>();

        usuarioYEdad.Add("Pepe", "2" );  
        usuarioYEdad.Add("Jose", "38");  
        usuarioYEdad.Add("Pedro", "12");  
        usuarioYEdad.Add("Ana", "15");
    }
}


