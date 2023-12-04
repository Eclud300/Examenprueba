using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using System.ComponentModel;


namespace Examenprueba.Models
{
    public class CaligrafiaViewModel
    {
        public INavigation navigation { get; set; }

        public event PropertyChangedEventHandler Propertychanged;

        public void OnpropertyChanged([CallerMemberName] string nombre = "Frecuencia cardiaca");
        { 
           private ImageSource foto;

            private ImageSource FOTO
        {
            get { return foto; }

            set => foto = value; {

                if (foto != null)
                {


                }
            }


               {
                foto = value;


            }


        }




    }
          

        







    }
}
