using System.Collections.Generic;
using Datos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq.Expressions;

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
            foreach(string mensajes in listaDeEjemplo)
            {
                todos += mensajes;
            }

            IEnumerable <string>  primero = listaDeEjemplo.Select(x => x.Trim().j

        }  
        
}
}


