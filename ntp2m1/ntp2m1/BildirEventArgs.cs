namespace ntp2m1
{
    class BildirEventArgs : EventArgs
    {
		private string propertyName;

		public string PropertyName
		{
			get { return propertyName; }
			set { propertyName = value; }
		}

        public object OldValue { get; set; }
        public object NewValue { get; set; }
        public BildirEventArgs(string prop, object oldValue, object newValue)
        {
            propertyName = prop;
            OldValue = oldValue;
            NewValue = newValue;
        }

    }
}
