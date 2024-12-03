using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knn {
  class ScrollWatchListBox : ListBox {
    public event EventHandler TopIndexChanged;
    private GUI dieGUI;
    public new int TopIndex {
      get { return base.TopIndex; }
      set {
        int oldvalue = base.TopIndex;
        base.TopIndex = value;
          if (TopIndexChanged != null) {
            TopIndexChanged(this, new EventArgs());
          }
      }
    }

    public ScrollWatchListBox(GUI pGUI) {
      dieGUI = pGUI;
      this.HorizontalScrollbar = true;
    }
    protected override void WndProc(ref Message m) {
      if (m.Msg == 20) //15 or 20 will work
      {
        //You can add code here to do what you want      

        // Do remember dont using MessageBox here,

        //it will get into dead loop if you use some win forms here     

        // you can watch the output when using debuging    
        dieGUI.updatePanel();
      }
      base.WndProc(ref m);
    }
  }
}