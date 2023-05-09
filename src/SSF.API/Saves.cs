//
//  Saves.cs - Standardized Save Files
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

using SSF.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSF.API
{
  public static class Saves
  {
    private static Dictionary<Dictionary<Save, string>, string> saveCategories = new();

    public static bool Add(string path, string name, SaveType type = SaveType.Symlink)
    {
      try
      {
        //saves.TryAdd(new Dictionary<Save, string>(path, name, type), name);
        saveCategories[0] 
      }
      catch (ArgumentNullException ex)
      {

      }
    }

    public static bool Remove()
    {

    }

    public static bool Clear()
    {
      return saves.Clear();
    }

    public static bool LoadFromFile()
    {

    }
  }
}
