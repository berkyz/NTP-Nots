namespace ntp2m1
{
    class Dosya
    {
		public delegate void BildirEventHandler(object sender, BildirEventArgs args);
		public event BildirEventHandler PropertyChanged;
		private string filename;

		public string Filename
		{
			get { return filename; }
			set 
			{
				if (!filename.Equals(value))
				{
					var args = new BildirEventArgs("Filename", filename, value);
					filename = value;
					Bildir(args);
				}

			}
		}

        public Dosya()
        {
			filename = "";
        }
        private void Bildir(BildirEventArgs e)
		{
			if(PropertyChanged != null)
				PropertyChanged(this, e);
		}

	}
}
