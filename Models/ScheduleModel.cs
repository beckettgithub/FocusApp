using FocusApp.DataInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusApp.Models
{
    public class ScheduleModel : IGUIObject
    {
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public Color BackgroundColor { get; set; }

        public void Initialize()
        {
            
        }
        public void Draw()
        {

        }
        public void Update()
        {

        }
        public void Remove()
        {

        }
        public void OnClicked()
        {

        }
        public void OnDragged()
        {

        }
    }
}