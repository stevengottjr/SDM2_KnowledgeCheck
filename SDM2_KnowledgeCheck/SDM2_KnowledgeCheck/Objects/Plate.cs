using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SDM2_KnowledgeCheck.Objects
{
    public class Plate : Part
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Description: {Description}, Length: {Length}, Width: {Width}, Height: {Height}"; 
        }
    }
}
