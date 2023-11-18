class Arrow {
    public Arrow() { }
    public Arrow(string head, string tail, int length){
        ArrowHead = head;
        ArrowTail = tail;
        ArrowLength = length;
    }
    public string ArrowHead { get; set;}
    public  string ArrowTail { get; set;}
    public int ArrowLength { get; set; }

    public static Arrow CreateEliteArrow(){
        Arrow eliteArrow = new Arrow("steel", "plastic", 95);
        return eliteArrow;
    }
    public static Arrow CreateBeginnerArrow(){
        Arrow beginnerArrow =  new Arrow("wood", "goose feathers", 75);
        return beginnerArrow;
    }
    public static Arrow CreateMarksmanArrow(){
        Arrow marksmanArrow = new Arrow("steel", "goose feathers", 65);
        return marksmanArrow;
    }
}