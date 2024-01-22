using System;
using System.Collections.Generic;
using System.Text;
using Triggersxd.VistaModelo;

namespace Triggersxd.Modelo
{
    public class Mcategorias : BaseViewModel
    {

        public string Descripcion { get; set; }
        public int NumeroItem { get; set; }
        public string Imagen { get; set; }

        //Objetos que interactuan con la interfaz

        private string _BackgroundColor;
        private string _textColor;
        private bool _selected;

        

        public string backgroundColor
        {
            get { return _BackgroundColor; }
            set { SetValue(ref _BackgroundColor, value); }
        }

        public string textColor
        {
            get { return _textColor; }
            set { SetValue(ref _textColor, value); }
        }
        public bool selected
        {
            get { return _selected; }
            set { SetValue(ref _selected, value); } 
        }


        

    }
}
