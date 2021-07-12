using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ozeki.Camera;
using Ozeki.Media;
using Ozeki.Media.MediaHandlers;
using Ozeki.Media.MediaHandlers.IPCamera;
//using Ozeki.Media.MediaHandlers.Video;
//using Ozeki.Media.Video.Controls;


namespace MoonBuggyGUI
{
    public partial class Camera : Form
    {
        /*
        _camera = IPCamera.GetCamera("192.168.115.198:8080", "admin", "admin") // It initializes the camera device that has been declared as a private member of the class. The used arguments are the followings: the IP address of the camera, username and password.
        _connector.Connect(_camera.VideoChannel, _imageProvider) // It can be used to establish the connection between the IP camera image and the image provider object that is used to display the image on the GUI.
        _camera.Start() // For getting the IP camera image from the camera, you need to start that.
        _videoViewerWF1.Start() // For displaying the IP camera image on the GUI, you need to start the viewer.
        //private Speaker _speaker; // In order to play the audio stream, you need an extra object, a speaker.
        _speaker = Speaker.GetDefaultDevice() // You need to initialize the new 'Speaker' object.
        _connector.Connect(_camera.AudioChannel, _speaker) // For the audio stream an other connection is also needed. You need to use the MediaConnector object. The arguments: the audio channel of the camera and the speaker object.
        _speaker.Start() // You need to start the speaker
        */

        private IPCamera _camera;
        private DrawingImageProvider _imageProvider = new DrawingImageProvider();
        private MediaConnector _connector = new MediaConnector();
        private VideoViewerWF _videoViewerWF1;
        private Speaker _speaker;
        public Camera()
        {
            InitializeComponent();
            // Create video viewer UI control
            _videoViewerWF1 = new VideoViewerWF();
            _speaker = Speaker.GetDefaultDevice();
            _videoViewerWF1.Name = "videoViewerWF1";
            _videoViewerWF1.Size = panel1.Size;
            panel1.Controls.Add(_videoViewerWF1);
            // Bind the camera image to the UI control
            _videoViewerWF1.SetImageProvider(_imageProvider);
        }

        // Connect camera video channel to image provider and start
        private void connectBtn_Click(object sender, EventArgs e)
        {
            _camera = IPCamera.GetCamera("192.168.115.175:8080", "admin", "admin");
            _connector.Connect(_camera.VideoChannel, _imageProvider);
            _connector.Connect(_camera.AudioChannel, _speaker);
            _camera.Start();
            _videoViewerWF1.Start();
            _speaker.Start();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            CommandCentre ss = new CommandCentre();
            ss.Show();
        }

        private void Logout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LogInScreen ss = new LogInScreen();
            ss.Show();
        }
    }
}
