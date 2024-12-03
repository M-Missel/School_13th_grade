using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knn {
  class ConfigLine {
    private string attr;
    private string val;

    public ConfigLine(string linestr) {
      string[] attrval = linestr.Split(new char[] {'='});
      attr = attrval[0];
      val = attrval[1];
    }

    public string getVal() {
      return val;
    }

    public string getAttr() {
      return attr;
    }

  }
}