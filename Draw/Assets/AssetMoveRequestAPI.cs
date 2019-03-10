namespace ManyWho.Flow.SDK.Draw.Assets
{
    public class AssetMoveRequestAPI
    {
        /// <summary>
        /// The key of the asset to move
        /// </summary>
        public string OldKey
        {
            get;
            set;
        }

        /// <summary>
        /// The key to move the asset to
        /// </summary>
        public string NewKey
        {
            get;
            set;
        }
    }
}
