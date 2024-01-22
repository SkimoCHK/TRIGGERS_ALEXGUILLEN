using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Triggersxd.Modelo;

namespace Triggersxd.Datos
{
    public class Dcategorias
    {
        public static ObservableCollection<Mcategorias> MostrarCategorias()
        {
            return new ObservableCollection<Mcategorias>()
            {
                new Mcategorias()
                {
                    Descripcion = "Cena",
                    NumeroItem =4512,
                    Imagen = "https://i.ibb.co/9c7xc4q/comida.png",
                    backgroundColor ="#EAEDF6",
                    textColor = "#000000"
                },
                new Mcategorias()
                {
                    Descripcion = "Hotel",
                    NumeroItem = 4512,
                    Imagen = "https://i.ibb.co/FWkH5Dp/cama.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                },
                new Mcategorias()
                {
                    Descripcion = "Fiesta",
                    NumeroItem = 4512,
                    Imagen ="https://i.ibb.co/s5p9zTg/papel-picado.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                },
                new Mcategorias()
                {
                    Descripcion = "Flores",
                    NumeroItem = 4512,
                    Imagen ="https://i.ibb.co/rv4chjM/maceta.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                }

            };
        }


    }
}
