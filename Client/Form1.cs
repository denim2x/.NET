using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Client {
  using MyPhotos;

  public partial class Form1 : Form {
    List<Media> media = new List<Media>();
    List<Attribute> attributes = new List<Attribute>();

    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      media = LoadMedia().ToList();
      grid_Media.DataSource = media;
      grid_Media.Columns[0].Width = 0;
      if (grid_Media.Rows.Count > 0) {
        grid_AttributeValue.DataSource = media[0].Attributes;
      }
      grid_Media.CellMouseClick += grid_Media_CellMouseClick;

      attributes = LoadAttributes().ToList();
      grid_Attribute.DataSource = attributes;
      grid_Attribute.Columns[0].Width = 0;
      grid_Attribute.CellMouseClick += grid_Attribute_CellMouseClick;
    }

    private static Media[] LoadMedia() {
      var client = new MyPhotosClient();
      var media = client.GetAllMedia();
      return media;
    }
    
    private static Attribute[] LoadAttributes() {
      var client = new MyPhotosClient();
      var attr = client.GetAllAttributes();
      return attr;
    }

    private void grid_Media_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
      if (e.RowIndex < 0)
        return;
      grid_AttributeValue.DataSource = null;
      grid_AttributeValue.DataSource = media[e.RowIndex].Attributes;
    }

    private void grid_Attribute_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
      if (e.RowIndex < 0)
        return;
      grid_AttributeValue.DataSource = null;
      grid_AttributeValue.DataSource = attributes[e.RowIndex].Values;
    }
  }
}
