int [] Sophia = {10,15,20,24,50};
int [] Andrew = {70,71, 80,85};
int [] Emma = {99, 95, 85,83};
int [] Logan = { 1,1,1,1};

static double average ( int [] numbers){
double sum = 0;
foreach(int score in numbers){
    sum =+ score;
}
return sum / numbers.Length;
}

static string mark ( double total ){
    if(total >= 97){
        return "A+";
    }
    else if(total>= 93){
        return "A";
    }      
    else if(total>= 93){
        return "A";
    } 
    else if(total>= 90){
        return "A-";
    }  
    else if(total>= 87){
        return "B+";
    }
    else if(total>= 83){
        return "B";
    }  
    else if(total>= 80){
        return "B-";
    }  
    else if(total>= 77){
        return "C+";
    }  
    else if(total>= 73){
        return "C";
    }  
    else if(total>= 70){
        return "C-";
    }  
    else if(total>= 67){
        return "D+";
    }  
    else if(total>= 63){
        return "D";
    }  
    else if(total>= 60){
        return "D-";
    }  
    else {
        return "F";
    }  

}    

static void StudentResult (string name, int [] score){
    double mode = average(score);
    Console.WriteLine($"{name} \t \t {mode} \t {mark(mode)}");
}
Console.WriteLine("Student \t Grade");
StudentResult("Sophia", Sophia);
StudentResult("Andrew", Andrew);
StudentResult("Logan", Logan);
StudentResult("Emma", Emma);

