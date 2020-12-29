using System;
namespace uiExp.Shared
{
    public class SelectionManager
    {
        private int numInConvo;
        public bool Selected { get; set; }

        public SelectionManager(int num)
        {
            this.numInConvo = num;
            //this.Selected = false;
        }
        public SelectionManager()
        {
            //this.Selected = false;
        }
        public void Clicked()
        {
            this.Selected = !this.Selected;
        }
        public void Select()
        {
            this.Selected = true;
        }
        public void UnSelect()
        {
            this.Selected = false; 
        }
        public bool GetSelect()
        {
            return this.Selected;
        }
        public int GetNum()
        {
            return this.numInConvo;
        }
        public void SetNum(int num)
        {
            this.numInConvo = num;
        }

    }
}
