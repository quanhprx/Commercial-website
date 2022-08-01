namespace BTLtestt
{
    public class Cart
    {
        public string id { get; set; }
        public string img { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string size { get; set; }
        public string total { get; set; }
        public string detail { get; set; }
        public string type { get; set; }
        public string number { get; set; }

        public Cart() { }

        public Cart(string id, string img, string name, string price, string detail, string number, string total, string size, string type)
        {
            this.id = id;
            this.img = img;
            this.name = name;
            this.price = price;
            this.size = size;
            this.number = number;
            this.total = total;
            this.detail = detail;
            this.type = type;
        }
    }
}