//Interface for the Merge Algorithm implementation class - Mohit Sahu

using DiffPlex.DiffBuilder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiffPlex
{
    
    /// <summary>
    /// Tesing for crossproject links
    /// </summary>
    /// <description>
    /// ![](mario_5c86064709f03f2c6040e3cf.jpeg)
    /// </description>
    public interface IMerger
    {
        
        
        SideBySideDiffModel GetMergedText(List<string> list);

        
        
        SideBySideDiffModel GetMergedText(SideBySideDiffModel model);
    }
}
