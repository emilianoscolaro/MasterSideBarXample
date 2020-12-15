using System;
using System.Collections.Generic;
using System.Text;
using RedCorners.Forms;
using Xamarin.Forms;

namespace MasterXample.ViewModel
{
    public class ContentPage1VM : BindableModel
    {

        public ContentPage1VM()
        {
           
        }


        bool _lightContent = true;
        public bool LightContent
        {
            get => _lightContent;
            set
            {
                _lightContent = value;
                UpdateProperties();
            }
        }

        public UIStatusBarStyles UIStatusBarStyle => LightContent ? UIStatusBarStyles.LightContent : UIStatusBarStyles.Default;

        #region SideBar Tests
        SideBarSides _side = SideBarSides.Right;
        public SideBarSides Side
        {
            get => _side;
            set => SetProperty(ref _side, value);
        }

        bool _isFullSize = false;
        public bool IsFullSize
        {
            get => _isFullSize;
            set => SetProperty(ref _isFullSize, value);
        }

        GridLength _contentSize = new GridLength(2, GridUnitType.Star);
        public GridLength ContentSize
        {
            get => _contentSize;
            set => SetProperty(ref _contentSize, value);
        }

        public Command<string> PlaceSideBarCommand => new Command<string>(side =>
        {
            if (Enum.TryParse<SideBarSides>(side, out var s))
                Side = s;
        });

        public Command AutoSizeCommand => new Command(() => ContentSize = GridLength.Auto);
        public Command Star2Command => new Command(() => ContentSize = new GridLength(2, GridUnitType.Star));
        public Command Absolute200Command => new Command(() => ContentSize = new GridLength(200, GridUnitType.Absolute));
        #endregion


    }
}
