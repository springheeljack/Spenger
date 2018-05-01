namespace Spenger.Components
{
    public class SelectComponent : Component
    {
        public string Name { get; private set; }
        public SelectComponent(string name)
        {
            Name = name;
        }
        //public void Update()
        //{
        //    var pos = Global.camera.CalculateDrawingPosition(Parent.transform.Position);
        //    if (InputManager.CurrentMouseState.Position.Intersects(pos, Parent.transform.Size * Global.camera.CameraComponent.ZoomLevel))
        //    {
        //        UIManager.HoveredInRange = false;
        //        UIManager.HoveredEntity = Parent;
        //        if (Parent.transform.Position.Distance(Global.player.transform.Position) <= Player.Reach)
        //            UIManager.HoveredInRange = true;
        //        if (InputManager.IsButtonHit(MouseButtons.Left))
        //            UIManager.SelectedEntity = Parent;
        //    }
        //    if (UIManager.SelectedEntity == Parent)
        //    {
        //        UIManager.SelectedInRange = false;
        //        if (Parent.transform.Position.Distance(Global.player.transform.Position) <= Player.Reach)
        //            UIManager.SelectedInRange = true;
        //        if (UIManager.HoveredEntity == Parent)
        //            UIManager.HoveredEntity = null;
        //    }
        //}
    }
}