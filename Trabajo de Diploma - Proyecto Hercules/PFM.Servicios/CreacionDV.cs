using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABSTRACCION;
using SERVICIOS;
using BE;

namespace FRAMEWORK
{
    public class CreacionDV
    {
        public string Generar(BEUser usuario)
        {
            string cadena = usuario.Username + usuario.Nombre + usuario.Apellido + usuario.Mail;
            Console.WriteLine($"Cadena para generar DVH: {cadena}"); 
            Criptografia Enc = new Criptografia();
            string dvh = Enc.Encriptador(cadena);
            Console.WriteLine($"DVH generado: {dvh}");
            return dvh;
        }

        public string GenerarDVV(List<string> listaDv)
        {
            string cadena = "";
            foreach (string dv in listaDv)
            {
                cadena = cadena + dv;
            }
            Console.WriteLine($"Cadena para generar DVV: {cadena}"); // Log para depuración
            Criptografia Enc = new Criptografia();
            string dvv = Enc.Encriptador(cadena);
            Console.WriteLine($"DVV generado: {dvv}"); // Log para depuración
            return dvv;
        }
    }
}

