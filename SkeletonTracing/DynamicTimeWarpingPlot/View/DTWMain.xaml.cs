﻿using DynamicTimeWarping;
using Microsoft.Win32;
using SkeletonModel.Managers;
using System.Windows;
using System.Windows.Controls;

namespace DynamicTimeWarpingPlot.View {
  public partial class DTWMain : UserControl {
    public DTWMain() {
      InitializeComponent();
    }

    public Computation Computation { get { return computation; } set { computation = value; } }

    public BodyManager BodyManager {
      get { return bodyManager; }
      set {
        bodyManager = value;
        skeletonCanvas.BodyManager = bodyManager;
      }
    }


    private void LoadGestureBtn_Click(object sender, RoutedEventArgs e) {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "XML file|*.xml";
      openFileDialog.ShowDialog();

      bodyManager.LoadCollection(openFileDialog.OpenFile());
    }

    private void LoadSampleBtn_Click(object sender, RoutedEventArgs e) {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "XML file|*.xml";
      openFileDialog.ShowDialog();

      bodyManager.LoadSample(openFileDialog.OpenFile());
    }

    private void ClearDataBtn_Click(object sender, RoutedEventArgs e) {
      bodyManager.ClearData();
    }

    private void PlayGestureBtn_Click(object sender, RoutedEventArgs e) {
      bodyManager.PlayGesture();
    }


    private BodyManager bodyManager;
    private Computation computation;
  }
}
