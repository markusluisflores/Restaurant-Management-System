﻿namespace RestaurantManagementSystem
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnReservationButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Reservation_input());
        }

        private async void OnGoToOrderButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderMain());
        }
    }

}
