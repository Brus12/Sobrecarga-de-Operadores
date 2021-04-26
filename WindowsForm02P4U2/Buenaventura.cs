using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace WindowsForm02P4U2
{
    public class Buenaventura
    {
        //Declaracion arreglos para cada dato
        ArrayList nombreP = new ArrayList();
        ArrayList telefonoP = new ArrayList();
        ArrayList nombreA = new ArrayList();
        ArrayList telefonoA = new ArrayList();
        //variables contadores
        int contNP = 0, contTP = 0, contNA = 0, contTA = 0;
        public int contTotal = 0;

        public ArrayList NombreP { get => nombreP; set => nombreP = value; }
        public ArrayList TelefonoP { get => telefonoP; set => telefonoP = value; }
        public ArrayList NombreA { get => nombreA; set => nombreA = value; }
        public ArrayList TelefonoA { get => telefonoA; set => telefonoA = value; }
        public void Datos(string nom, string tel)
        {
            NombreP.Add(nom);
            TelefonoP.Add(tel);
            contNP = NombreP.Count;
            contTP = TelefonoP.Count;
        }

        public void Datos(string nombre, long tel1)
        {
            NombreA.Add(nombre);
            TelefonoA.Add(tel1);
            contNA = NombreA.Count;
            contTA = TelefonoA.Count;
            contTotal = contNA + contNP;
        }
    }
}