//
//  Save.cs - Standardized Save Files
//   Copyright (C) 2023  'nonperforming'
//
//    This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Affero General Public License as
//  published by the Free Software Foundation, either version 3 of the
//  License, or (at your option) any later version.
//
//  You should have received a copy of the GNU Affero General Public License
//  along with this program.  If not, see <https://www.gnu.org/licenses/>.
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace SSF.Serialization
{
  public class Save
  {
    public Save(string path, string name, SaveType type)
    {
      Name = name;
      Type = type;
      Path = path;
    }

    public string Name { get; private set; }
    public SaveType Type { get; private set; }
    public string Path { get; private set; }
  }
}
