using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RoomLibrary;

namespace Rooms
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Room> lstRooms = new List<Room>();  //создание списка комнат
        public MainWindow()
        {
            InitializeComponent();
        }


        Room room = new Room();
        LivingRoom livingRoom = new LivingRoom();
        Office office = new Office();



        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       

        private void BAddRoom_Click_1(object sender, RoutedEventArgs e)
        {
            Room room = new Room();
            room.RoomLength = Convert.ToDouble(TBLengthR1.Text);
            room.RoomWidth = Convert.ToDouble(TBWidthR1.Text);
            lstRooms.Add(room); //добавление в список
        }

        
        private void BAddOffice_Click(object sender, RoutedEventArgs e)
        {
            Office office = new Office();
            office.RoomLength = Convert.ToDouble(TBLength10.Text);
            office.RoomWidth = Convert.ToDouble(TBWidth10.Text);
            office.NumSockets = Convert.ToInt32(TBNumS1.Text);
            lstRooms.Add(office);


        }



        

        private void TBLengthR_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BAddLivingRoom_Click(object sender, RoutedEventArgs e)
        {
            LivingRoom livingRoom = new LivingRoom();
            livingRoom.RoomLength = Convert.ToDouble(TBLengthL1.Text);
            livingRoom.RoomWidth = Convert.ToDouble(TBWidthL1.Text);
            livingRoom.NumWin = Convert.ToInt32(TBNumW1.Text);
            lstRooms.Add(livingRoom);
        }

        private void BGetList_Click_1(object sender, RoutedEventArgs e)
        {

            ListRoomss.Content = "";
            //вывод информации из списка
            foreach (Room r in lstRooms)
                ListRoomss.Content += r.Info() + "\n";
            
        }

        private void TBLength0_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }

    
}