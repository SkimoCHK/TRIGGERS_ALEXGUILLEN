using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Triggersxd.Datos;
using Triggersxd.Modelo;
using Triggersxd.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Triggersxd.VistaModelo
{
    public class VMcategoria : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        string _Imagen;
        bool _activadorAnimacionImg;
        private ObservableCollection<Mcategorias> _listaCategorias;
        #endregion
        #region CONSTRUCTOR
        public VMcategoria(INavigation navigation)
        {
            Navigation = navigation;
            MostrarCategorias();
        }
        #endregion
        #region OBJETOS
        public string Imagen
        {
            get { return _Imagen; }
            set { SetValue(ref _Imagen, value); }
        }

        public bool ActivadorAnimacionImg
        {
            get { return _activadorAnimacionImg; }
            set { SetValue(ref _activadorAnimacionImg, value); }
        }

        public ObservableCollection<Mcategorias> ListaCategorias
        {
            get { return _listaCategorias; }
            set { SetValue(ref _listaCategorias, value);}
        }
        #endregion
        #region PROCESOS
        public void MostrarCategorias()
        {
            ListaCategorias = new ObservableCollection<Mcategorias>(Dcategorias.MostrarCategorias());
        }
        public void Seleccionar(Mcategorias modelo)
        {
            var index = ListaCategorias
                .ToList()
                .FindIndex(p => p.Descripcion == modelo.Descripcion);

            Imagen = modelo.Imagen;
            if (index > -1)
            {
                Deseleccionar();
                ActivadorAnimacionImg = true;
                ListaCategorias[index].selected = true;
                ListaCategorias[index].textColor = "FFFFFF";
                ListaCategorias[index].backgroundColor = "FF506B";
            }
        }
        public void Deseleccionar()
        {
            ListaCategorias.ForEach((item) =>
            {
                ActivadorAnimacionImg = false;
                item.selected = false;
                item.textColor = "#000000";
                item.backgroundColor = "#EAEDF6";
            });
        }
        #endregion
        #region COMADNOS
        public ICommand ProcesoSimpcomand => new Command(MostrarCategorias);
        public ICommand Seleccionarcomand => new Command<Mcategorias>((p) => Seleccionar(p));
        #endregion

    }
}
