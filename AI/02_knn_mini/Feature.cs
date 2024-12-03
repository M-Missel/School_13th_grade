using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace knn {
  public class Feature {
    protected string label;

    public Feature(string label) {
      this.label=label;
    }

    public string getLabel() {
      return label;
    }
  }
}