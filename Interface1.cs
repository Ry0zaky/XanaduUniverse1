using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace XanaduUniverse
{
    internal interface ISpeakFrench
    {
        void sing();
        void speak();
    }

    internal interface ICanEat
    {
        void eat();
    }
    internal interface ICanDance
    {
        void dance();
    }
    internal interface ISnore
    {
        void snore();
    }
    internal interface ICodeCSharp
    {
        void writecode();
    }
    abstract class Humanoid
    {
        public abstract void socialize();
    }
    class YY : Humanoid, ISpeakFrench, ICanEat
    {
        public void speak()
        {
            string Speak = "Je suis YY et j'aime la France";
            MessageBox.Show(Speak);
        }
        public void sing() { }
        public void eat()
        {

        }
        public override void socialize()
        {
            speak();
            eat();
        }

    }
    class ZZ: Humanoid, ISpeakFrench, ICanDance
    {
        public void sing()
        {
            SoundPlayer player = new SoundPlayer(@"C:Sounds/Song.wav");
            player.Play();
        }
        public void speak() { }
        public void dance()
        {
            Form form = new Form();
            form.Width = 320;
            form.Height = 240;
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = Image.FromFile("C:Pictures/giphy.gif");
            form.Controls.Add(pictureBox);
            form.ShowDialog();
        }
        public override void socialize()
        {
            sing();
            dance();
        }
    }
    class NN: ZZ, ICodeCSharp
    {
        public void writecode()
        {
            string Code = "print('Hello World')";
            MessageBox.Show(Code);
        }
        public override void socialize()
        {
            sing();
        }
    }
    class DD: NN, ISnore
    {
        public void snore()
        {
            Form form = new Form();
            form.Width = 700;
            form.Height = 500;
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = Image.FromFile("C:Pictures/Sleep.gif");
            form.Controls.Add(pictureBox);
            form.ShowDialog();
            SoundPlayer player = new SoundPlayer(@"C:Sounds/Snore.wav");
            player.Play();
        }
    }
}
