using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Text.Core;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace Save_the_Humans
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Random random = new Random();
        DispatcherTimer enemyTimer = new DispatcherTimer();
        DispatcherTimer targetTimer = new DispatcherTimer();
        bool humanCaptured = false;
        public MainPage()
        {
            this.InitializeComponent();
            enemyTimer.Tick += EnemyTimer_Tick;
            enemyTimer.Interval = TimeSpan.FromSeconds(2);

            targetTimer.Tick += TargetTimer_Tick;
            targetTimer.Interval = TimeSpan.FromSeconds(.1);
            string imagePath = "ms-appx:///Assets/PirateShip.png";
            
        }

        private void TargetTimer_Tick(object sender, object e)
        {
            progressBar.Value += 2;
            if (progressBar.Value >= progressBar.Maximum)
                EndTheGame();
        }

        private void EndTheGame()
        {
            if (!playArea.Children.Contains(gameOverText))
            {
                enemyTimer.Stop();
                targetTimer.Stop();
                humanCaptured = false;
                startButton.Visibility = Visibility.Visible;
                playArea.Children.Add(gameOverText);
            }
        }

        private void EnemyTimer_Tick(object sender, object e)
        {
            addEnemy();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            startGame();
        }

        private void startGame()
        {
            human.IsHitTestVisible = true;
            humanCaptured = false;
            progressBar.Value = 0;
            startButton.Visibility = Visibility.Collapsed;
            playArea.Children.Clear();
            playArea.Children.Add(island);
            playArea.Children.Add(human);
            enemyTimer.Start();
            targetTimer.Start();
        }

        private void addIsland()
        {
            ContentControl island 
        }
        private void addEnemy()
        {
            ContentControl enemy = new ContentControl();
            enemy.Template = Resources["EnemyTemplate"] as ControlTemplate;
            AnimateEnemy(enemy, 0, playArea.ActualWidth - 100, "(Canvas.Left)");
            AnimateEnemy(enemy, random.Next((int)playArea.ActualHeight - 100),
                random.Next((int)playArea.ActualHeight - 100), "(Canvas.Top)");
            playArea.Children.Add(enemy);
            enemy.PointerEntered += Enemy_PointerEntered;
        }

        private void Enemy_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (humanCaptured)
                EndTheGame();
        }

        private void AnimateEnemy(ContentControl enemy, double from, double to, string propertyToAnimate)
        {
            Storyboard storyboard = new Storyboard() { AutoReverse = true, RepeatBehavior = RepeatBehavior.Forever };
            DoubleAnimation animation = new DoubleAnimation
            {
                From = from,
                To = to,
                Duration = new Duration(TimeSpan.FromSeconds(random.Next(4, 6)))
            };
            Storyboard.SetTarget(animation, enemy);
            Storyboard.SetTargetProperty(animation, propertyToAnimate);
            storyboard.Children.Add(animation);
            storyboard.Begin();
            
        }

        private void human_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if (enemyTimer.IsEnabled)
            {
                humanCaptured = true;
                human.IsHitTestVisible = false;
            }
        }

        private void target_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (targetTimer.IsEnabled && humanCaptured)
            {
                progressBar.Value = 0;
                Canvas.SetLeft(island, random.Next(100, (int)playArea.ActualWidth - 100));
                Canvas.SetTop(island, random.Next(100, (int)playArea.ActualHeight - 100));
                Canvas.SetLeft(human, random.Next(100, (int)playArea.ActualWidth - 100));
                Canvas.SetTop(human, random.Next(100, (int)playArea.ActualHeight) - 100);
                humanCaptured = false;
                human.IsHitTestVisible = true;
            }
        }

        private void playArea_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            if (humanCaptured)
            {
                Point pointerPosition = e.GetCurrentPoint(null).Position;
                Point relativePosition = grid.TransformToVisual(playArea).TransformPoint(pointerPosition);
                if ((Math.Abs(relativePosition.X - Canvas.GetLeft(human)) > human.ActualWidth * 3)
                    || (Math.Abs(relativePosition.Y - Canvas.GetTop(human)) > human.ActualWidth * 3 ))
                {
                    humanCaptured = false;
                    human.IsHitTestVisible = true;
                }
                else
                {
                    Canvas.SetLeft(human, relativePosition.X - human.ActualWidth / 2);
                    Canvas.SetTop(human, relativePosition.Y - human.ActualHeight / 2);
                }
            }
        }

        private void playArea_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (humanCaptured)
                EndTheGame();
        }

        private void addIslandButton_Click(object sender, RoutedEventArgs e)
        {

        }

        //// Agregation----------
        //Meer karibisches = new Meer("Karibisches Meer");
        //Meer meer2 = new Meer("Meer2");
        ////Insel nevis = new Insel("Nevis");
        ////Lokation lokation = new Lokation("test_location");
        ////Lokation strand1 = new Strand("\"lange dinge Strand\"");
        ////Lokation Strand2 = new Strand("\"Kurz dinge Strand\"");
        ////Lokation kneipe1 = new Kneipe("\"ertrunken betrunken Pirat Kneipe\"");
        ////----------------------------------
        //// ---------------------Komposition--------------------
        //Insel nevis = karibisches.CreateInseln("Nevis");
        //Insel monkey = meer2.CreateInseln("Monkey 's Island");
        //Strand strand1 = nevis.CreateStrand("\"lange dinge Strand\"");
        //Strand strand2 = monkey.CreateStrand("\"Kurz dinge Strand\"");
        //Kneipe kneipe1 = nevis.CreateKneipe("\"Kneipe1\"");
        //Kneipe kneipe2 = monkey.CreateKneipe("\"ertrunken betrunken Pirat Kneipe\"");
        ////------------------------------------------------
        //Pirat guybrush = new Pirat("GuyBrush", strand1);
        //Pirat elaine = new Pirat("Elaine", strand1);
        //Pirat leChuck = new Pirat("LeChuck", kneipe1);
        //Schiff schiff1 = new Schiff("Golden Made", strand1);
        ////Console.WriteLine("test:{0}",lokation.GetPiraten());
        //ZeigtPiraten(strand1);
        //Console.WriteLine("LeChuck ist in "+leChuck.GetAktL().GetBez());
        //    leChuck.bewegen(strand1);
        //    Console.WriteLine("Piraten, die in {0} sind: ",strand1.GetBez());
        //    ZeigtPiraten(strand1);
        ////Pirat[] piraten = strand1.GetPiraten();
        ////Console.WriteLine(piraten[0].GetName());
        ////Console.WriteLine(piraten[1].GetName());
        ////Console.WriteLine(piraten[2].GetName());
        //elaine.bewegen(kneipe1);
        //    Console.WriteLine("Piraten die in {0} sind ", kneipe1.GetBez());
        //    Pirat[] piraten2 = kneipe1.GetPiraten();
        //Console.WriteLine(piraten2[0].GetName());
        //    Console.WriteLine(piraten2[1].GetName());
        //    leChuck.Reise(kneipe1, strand1, schiff1, karibisches, meer2, strand2);
        //    //Console.WriteLine("test:{0}", lokation.GetPiraten()[0].GetName());
        //public static void ZeigtPiraten(Lokation lokation)
        //{
        //    Pirat[] piraten = lokation.GetPiraten();
        //    foreach (Pirat pirat in piraten)
        //        if (pirat != null)
        //        {
        //            Console.WriteLine(pirat.GetName());
        //        }
        //}

    }
}
