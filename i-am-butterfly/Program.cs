using System;
class Program
{
    static void Main()
    {
        Console.Title = "I am butterfly";
        Central_text("ARTEM HRYSHCHENKO", 2, 3000);
        Central_text("small story", 2, 3000);
        Central_text("about long way", 2, 3000);
        Greeting_one();
        Greeting_two();
        Central_text("CHAPTER 1: FALLING FROM ROUTINE", 1, 5000);
        Butterfly_animation();
        Central_text("???", 2, 1000);
        Eye_animation();
        Central_text("what", 2, 1000);
        Family_animation();
        Central_text("I CAN'T ...", 2, 1000);
        Cow_animation(50, 1);
        Central_text("and small butterfly was lying on grass...", 2, 2000);
        Central_text("and no one can shame her...", 2, 4000);
        Central_text("CHAPTER 2: RISE", 1, 5000);
        Central_text("I don't remember this things from my life", 2, 3000);
        Central_text("this is a very wierd feeling", 2, 3000);
        Home_or_wellspring();
    }
    static void Up_text(string text, int mode = 1)
    {
        if (mode == 1)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        else if (mode == 2)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (mode == 3)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
        }

        Console.Clear();
        Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
        Console.WriteLine(text);
        return;
    }
    static void Central_text(string text, int mode=1, int duration=1000)
    {
        if(mode == 1)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        else if(mode == 2)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (mode == 3)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
        }

        Console.Clear();
        for (int j = 0; j < Console.WindowHeight/2; j++)
        {
                Console.WriteLine(" ");
        }
        Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
        Console.WriteLine(text);
        Thread.Sleep(duration);
        Console.Clear();
        return;

    }
    static void Greeting_one()
    {
        for(int i = 0; i < 200; i++)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            string s = "I AM BUTTERFLY";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Thread.Sleep(1);
        }
        
    }
    static void Greeting_two()
    {
        for (int i = 0; i < 300; i++)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            string s = "DREAMING I AM MAN";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Thread.Sleep(1);
        }
    }
    static void Butterfly_animation(int speed=50, int repeats=7)
    {

        string _1 = @"                                                                                                    
                                                                                                    
                                         %#/&                                                       
                                        %%#/%%%#&                                                   
                                       %%&&%%%%@#@                                                  
                                      %%&&%#//%%&&(                                                 
                                     %%&%%*(%%&&&&(                                                 
                                    (/&%#/&(/**&@&                                                  
                                   .%&%%/&(/#&&&@@                                                  
                                   *&&%*&&/(@/*@@&                                                  
                                    .&%*&@*(@//@@                                                   
                                 ***&&(@&&**%@/@&                                                   
                               /*&#,@@*&***@*%&@                                                    
                              /&,*/#(#***%**@@& /                                                   
                             (@(,**#**#*///@@(@@(                                                   
                              @//&,#@*(/.   *                                                       
                                           /                                                        
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ";
        string _2 = @"                                                                                                    
                                                                                                    
                                       %(*%,                                                        
                                      %%%///%    **                                                 
                                     %&&&(///& #%%%&                                                
                                    #%&&@(//((%(%%&&#                                               
                                    %&&&@///%(#//%@&%                                               
                                   ##&@@@@&%%%&@&&@@                                                
                                  %&&&%@@%#/&/@@&@&,                                                
                                  /&@@&&%////@/*&@@                                                 
                                    @@@%((&*#@**@@,                                                 
                                *****/@%&&&*/@(/@*                                                  
                              /**/,*/*@%@@*@//%@        /                                           
                             /**/&,@@,,&&@**#@@,/ .                                                 
                             ***,,/**&@@%%%@@#@@(                                                   
                             .*(,*/,%##(.   /                                                       
                                           *                                                        
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ";

        string _3 = @"                                                                                                    
                                                                                                    
                                     #%*%                                                           
                                    ,%&*/*%                                                         
                                   .%&&#*/*&.                                                       
                                   #%&&@////&       (%%                                             
                                  %%&&&@#////&     %&@%(                                            
                                 **&&@@@@@////* (#/(&@@                                             
                                 %%@&%@@@/////%%#&%&&@                                              
                                 *&&@&&@@@//#%/%%@@@@                                               
                                   @&@%&&@@%(%/&//@@                                                
                               .***,*#@@@%&&%/&@/@&                                                 
                             ,*/**,*,,*,(%&@%((/@                                                   
                            #****/(//*(@*////@@%/ ,                                                 
                            #***/*&//*////(@@#@@(                                                   
                             ,,*&/@(//##.   *                                                       
                                /(         /                                                        
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ";
        string _4 = @"                                                                                                    
                                                                                                    
                                                                                                    
                                    %(*&                                                            
                                   %%&*(*&                                                          
                                   %%%&**(*&                                                        
                                 ,#%&&&/////&                                                       
                                 (#&&&@*////*             *&                                        
                                .%%&&@@@/////(         *%@&                                         
                                .&&@%&@@@///**/     .(/&&                                           
                                 *@@@@&&@@@***/   #@/&@                                             
                               /*(*,%@@@&&@@***%%@(%@                                               
                             %*****.,*,,**%@&/%/&/&                                                 
                            (**/*/(/*,,,,,,#/#%#,  *                                                
                           .****/***/**/##//@#@@/                                                   
                             (***,*/*(//#   *                                                       
                                  /,       *                                                        
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ";

        string _5 = @"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                    /#*                                                             
                                   %%%**/#                                                          
                                  *#%&&****#                                                        
                                 ,#%&&&/*//*(                                                       
                                 (#&&&@/(///*.                                                      
                                *&&@%@@@////*/                                                      
                                *&&@&&%@@%/***#               .                                     
                                  .@@&%&&@@@***                                                     
                              ***/*./*/#/%@@@*#      .                                              
                            /****//,...,**,,/#@  #    /(@                                           
                            /****/*/******,&&(@@/                                                   
                            (/****,*%&(**   *                                                       
                                     .     *                                                        
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ";

        string _6 = @"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                    .%**%                                                           
                                   ,%&%****(                                                        
                                   %%&@/*/**&                                                       
                                  %%&&&#%(///%                                                      
                                 %%@%@@&#////*,                                                     
                                 &&@&&&&@@@****                                                     
                                  ((&@@@&@@@%*/               .&&&%(                                
                              *****,,,,,,***@@@    .***//*//*&&&&*                                  
                            (*****///(((//*&&@**@&&@@@@&&&(                                         
                            #******,*(%** *****@@&%%,                                               
                                 .    (**/***                                                       
                                   *****                                                            
                                                                                                    
                                                                                                    
                                                                                                    ";
        string _7 = @"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                     .%#/*/#                                                        
                                    ,%%&(///*#                                                      
                                   /%&&&/(////#                                                     
                                  %(@%@@@(//***                                                     
                                  &&&@&&&@@@***/                                                    
                                 */****%//*&%@@                                                     
                              ***/********#%&@&@&@@@/**///////**/**/&,                              
                             *********#,, (**,,/%&&&&@@@@@@&&&&&&%%%#(,                             
                              #(,%    ,(*//**,**@@%@@@@&%%%((,                                      
                                    #***/*****/                                                     
                                   /(*/,(                                                           
                                                                                                    
                                                                                                    ";
        string _8 = @"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                         *(*                                                        
                                      .%%%//(*%                                                     
                                     (%&@/%*//*,                                                    
                                    /@%@@@@/***#                                                    
                                   #@@@@@&@@@@@                                                     
                                 ,*/*,*,,,*%%@@&@@*********#(                                       
                              /****/***#* (**,,**@@@@@(*///////****&,                               
                             ,*****    %****,*,,@@@&&%@@@@@@(*#//#*//**%                            
                                    (****///,*****@&@@@@@&&&&%%&%%&%%%%%                            
                                   ,*/**/*****/                                                     
                                                                                                    
                                                                                                    ";
        string _9 = @"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                         *(*                                                        
                                      .%%%//(*%                                                     
                                     (%&@/%*//*,                                                    
                                    /@%@@@@/***#                                                    
                                   #@@@@@&@@@@@                                                     
                                 ,*/*,*,,,*%%@@&@@*********#(                                       
                              /****/***#* (**,,**@@@@@(*///////****&,                               
                             ,*****    %****,*,,@@@&&%@@@@@@(*#//#*//**%                            
                                    (****///,*****@&@@@@@&&&&%%&%%&%%%%%                            
                                   ,*/**/*****/                                                     
                                                                                                    
                                                                                                    ";
        string _10 = @"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                          //**/&                                                    
                                        %&&////*                                                    
                                      /@&@@@@%**                                                    
                                    *@@&/,**%@%&&/,***#*                                            
                                  *.*//*..*,(**,*@@@@/****//*/%(                                    
                               *****   #/**(*,*,#@&&&@@@/////////*/&%                               
                                     #,****/,(.**@@@&&&@@@@@@(//*//*/*(%                            
                                    /*******/**** ,@&&&@@@&&&@&%&%%%&%%**(                          
                                     **//*/*/,           . ....                                     
                                                                                                    ";
        string _11 = @"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                          %**//&                                                    
                                        %&&(///*                                                    
                                      #%&@@@@&*,                                                    
                                    #*&/,,**%@%&&(*****(#                                           
                                 ,*.*/**.,/*/*,,*@@@@#****////*%/                                   
                               ****%   %/**/*,*,&@&&&@@@(/*/////****&                               
                                    .#,***//*(.**@@&@&&&@@@@@@&#((/**/*%*                           
                                    *****///****# .&&%&%&&&%&&%%&%&&%%&##.                          
                                     */*/*/(*                                                       
                                                                                                    ";
        string _12 = @"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                          **%%.                                                     
                                       .%%/*///#                                                    
                                      %&&@%/****                                                    
                                    &&@&&&&@@@*                                                     
                                   /,(/***,*%@&&@&,******/(,                                        
                                ,*//*/*%, (*/,,**@@@@@///*////*/**&%.                               
                              /***,    %****,,,,@@@&%%@@@@@@*/******/*%.                            
                                    */***///.***,%@@&@@&&&%&%%%&&%&%&%/#*                           
                                   ,****/****/**    ,///,,,                                         
                                                                                                    
                                                                                                    ";

        string _13 = @"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                       //**%#                                                       
                                      #%&(//**(                                                     
                                    *%&&%@///**                                                     
                                   %%@%%@@@&***(                                                    
                                   /@@@@@@@@@@@        ,/                                           
                                /*****,,,**&&@&@@@@(****///////*//(&*                               
                              ******/**(* #/*,,(#@&&@@@@@@@/*%/(&*/*/**(                            
                             ./****   ,#**//,,,/@&&@@&%@&&&&%%##%%.                                 
                                    #****/****,                                                     
                                   .**//*/                                                          
                                                                                                    
                                                                                                    ";
        string _14 = @"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                     %&/*/*&.                                                       
                                    %&&&/****#                                                      
                                   %%&&&&%///*#                                                     
                                  %%@%@@@%//***                                                     
                                  &@&@&&&&@@/**/                                                    
                                .***(*,,(/*%%@@    /****///*//**///%                                
                              **/*/******/#%&@(/@@@@@@@@&&&%#,                                      
                             /********#*, **,,*@&&&&%#,                                             
                             ,..,,    ,*/(,*,.                                                      
                                   ,****,                                                           
                                                                                                    
                                                                                                    
                                                                                                    ";
        string _15 = @"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                    /%**%,                                                          
                                   (%&%**/*&                                                        
                                  /%%&&*//**&                                                       
                                 .(%&&%@@///*%                                                      
                                 %%@%@@@&//***,                .                                    
                                 %&&@&&&@@@****           .#                                        
                                @#*,(@@@@@@@@*/       #*                                            
                              ,**,*,,,,*,,*,@@@ ,(#                                                 
                            (***//*///((//*&&,&@(                                                   
                            %********#%***. *                                                       
                                 .   ..    /                                                        
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ";
        string _16 = @"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                    /#*                                                             
                                   %&%**/#                                                          
                                  *#%&&****#                                                        
                                 ,#%&&&**/**(              %                                        
                                 (#&&&@/(////.          %&&                                         
                                *%&@%@@@////*/       #/&@                                           
                                *&@@&&%@@%****#   *@/&@                                             
                                  .@@&&&@@@@**/ (@@/&                                               
                              ***/*,/*/#/%@@@(&/@/*                                                 
                            /****//,..,,**,#*%%%/ /                                                 
                            /****/**/*/*%//*@#@@(                                                   
                            (/****,**/(/#   *                                                       
                                  /,.      *                                                        
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ";
        string _17 = @"                                                                                                    
                                                                                                    
                                                                                                    
                                    ##*/                                                            
                                   %%&***%                                                          
                                  /#%%%/*/*#        %%&                                             
                                  #%%&@///(*/     %%%&&(                                            
                                 #%&&&@///*//.  %//&&&@                                             
                                .%&@@@@@*////(%%%(&&@@                                              
                                ,&%@&&@@@///%/&/@@@@@                                               
                                 ,@@@&&&@@%(#//@(#@@                                                
                               *,/*,&@@&&%#&&/@&/@&                                                 
                             ,*****.,*,,%&@@%(#/@      &                                            
                            /****///&*@@*////@@(/                                                   
                           .****/**&**////(@@#@@(                                                   
                            ./**%*%///((.   *                                                       
                                #%.        /                                                        
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ";
        string _18 = @"                                                                                                    
                                                                                                    
                                     %#&                                                            
                                    %&%/*&,    /#%.                                                 
                                   .%&&//(*& .%%%%&                                                 
                                   #%&&&//*/%%/%%@&@                                                
                                  %%&&&%///%/%%#%&&&                                                
                                 /*%&&&@%%%*&#/#&&&%                                                
                                 %&@%&@@%#%&/(&@@@@                                                 
                                 %&@@&%%%/%//@/#@@,                                                 
                                  ,@@@%%&#/*&@*&@@                                                  
                               .***,*&@%&&%//@/%@*                                                  
                              */*,,#,@&&@**@*/(@%     /                                             
                            ,***/,,@,*@&@@**@@@,/                                                   
                            /**@,/**%*@&%##@@#@@(                                                   
                             &*,##//@#(/.   *                                                       
                                           *                                                        
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ";

        // https://manytools.org/hacker-tools/convert-images-to-ascii-art/go/
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WindowWidth = 120;
        Console.WindowHeight = 22;

        string[] butterfly_frames = new string[] {_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18};
        for(int i=0;i< repeats;i++)
        {

            foreach (string butterfly_frame in butterfly_frames)
            {

                Console.WriteLine(butterfly_frame);
                Thread.Sleep(speed);


            }
        }
        
    }
    static void Eye_animation(int speed=50, int repeats=3)
    {

        string _0 = @"
%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%######((((((///(////////////(///(///(
%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&%%%%%%#####(#((((//////////////*////**//////*//
#%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&%%%%%%%##((((((////////********/**************//
##%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%##((((#####((((/////////************************
#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##((((((((/(((((////*****************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%####(((((((((/////////*************,,,,**********,,,
%%%%%%%%%%%%%%%%%%%%%%%%%%##((((((((((((((///******************,,**,,,**,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%%#####(((//////////////***************,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%%%#####((/*******************,,,,,,,,,,,,,,,,,,,,,,,,,,,
####%%%%%%%########%%%%%#######((//***********,,,,,,,,,,,,,,,,,,*,,,,,,,,,,,,,,,
###%%%%%%%%##############((((((///******,,,,,,,,,,,,,,,,,,,,,,,,..,,.,,,,,,,,,,,
%%%%%%%%#############(((//////******,,,,,,,,,,,,,,,,,,,,,,,....,,,,,........,,,,
%%%%%%%%#############((((////***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,........,,,,
%%%%%%%%%%%%%%%%%%%#######(((////****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,........,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%%%%%####(((/////***,,,,,,,,,,,,,,,..............,,,,,,,,
%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&%%%%%###(((//******,,,,,,,,,,,,..,,,...,,,,,,,,,,
%%%%%%%%%&&&&&%%&&&&&&&&&&&&&&&&&&%%%%%%%%%%###((((//****,,,,,,,,,,,,,,,,,,,,,,,";
        string _1 = @"
%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%######(((//////////////////////((///(
%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&%%%%%%##(((((((((//////////////**///**//////*//
#%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&%%%%%%%###(((((////////********/**************//
##%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%##(((((((##((((////***//************************
#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##(((((((///(((/////*****************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%#####(((((/((/////*****************,,,,***,****,*,,,
%%%%%%%%%%%%%%%%%%%%%%%%%%###((((((((((((////******************,,,,,,,**,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%%%#####(((//////***////******,,,,,****,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%%%######((/******************,,,,,,,,,,,,,,,,,,,,,,,,,,,
####%%%%%%%%%###%###%%%%#######((///*********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
###%%%%%%%%#############(((((((////****,,,,,,,,,,,,,,,,,,,,,,,,,.....,,,,,,,,,,,
%%%%%%%%#############((((/////*******,,,,,,,,,,,,,,,,,,,,,,,...,,,,,.........,,,
%%%%%%%%%%%%%%%%%%%######(((////****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,..........,,
%%%%%%%%%%%%%%%%%%%%%%%%%%%###(((((////****,,,,**,,,,,,,,,,,,,,..............,,,
%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%####(((//*******,,,,,,,...............,,,,,,,
%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%####((((///****,,,,,,,,,,...,,,,,,,,,,
&&&&&&&&&&&&%%%%%%%%%%%%%&&&&&&&&&&&&%%%%%%%%##%%%%%%###(//********,,,,,,,,,,,,,";
        string _10 = @"
((////////((((((((##%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%##(//(//****,,,,,,,,,,,,,
/////////////((##%%&&&&&&&&&&&&&&&&%%%&%&&&&&&&&&&&&&&&&&&&%%%#((/*****,,,,,,...
********///(##%%&&&&&&&&&&%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%##((/*,,,......
******//(##%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%##//*,,.....
****/((#%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%#((//****,,,
//((#########%%%%%&&&&&&&&&&&%%%&&&&&&&&&&&&@@&&&&&%%%%&&&&&&&%&&&&%%%#((/****,,
(###########%%%&&&&&&&&&&&&&&%(#&&&&&&%..&&&@@@&&&&&%%%#%%%%&&%##%%%%%#((/***,,,
(((((#####%%%&&&&&%%&&&&&&&&&,(*&&&&&&&&&&&&&&&&&&&&%%%%##%#(#%%%#(#%%####(/**,.
(((((###%%&&%%%%%%%%%%%%###%%%%&&%%%%%#%%%&&&&&&&&&%%%%%%#####(/(#%%%##((/**,...
(((((((##%%%%%########%#(((##%%#%%#(/####%###%%%#%%%%%%%%#######(//(###((//*,...
(((((///((##%%##((((##((///#(##/#//(###%%#((###//(#%%%%%##(((((#####((((//****,.
((/////////(####((((///*/*//*///(/((/(((/(((((***/((((((///((##########((((/*,. 
(((//////////(((((((/**//////////////(/ /##(/**,,,,*,,*//((//(//*//((((///////*,
(////***********,,,,,,,,,,,,,,........ ....,,,,,,*.,,,,*****/(*****//*//*,,,..  
////*********,,,,,,,,....,,......... .         ..  .. ..,..,,,,.,*,***,,,,...   
/////*************,,,,,,,,,............           .        .,. ...,,,,,....     
////**********,*****,,,,,,,,,,,,,,,,....   .. .              . ......,...       ";
        string _11 = @"
////////////(((##%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%###///***,,,,,,
///****////(##%%&&&&&&&&&&&%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%#(/***,,,..,
******//((##%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%#(//****,,,*
****//(##%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%&&%&&&&&&&&&%#(/******
///(#########%%%%%&&&&&&&&&&&&%%%%%%%&&&&&&&&&&&&&%%%%%&&&&&%&&&&&&&&&%(/*,,.,,,
((###########%%%&&&&&&&&&&&&&&#%#(#&&&&#&&&&@@@&&&&%%%%%##%##&&%#%%%%%%##(/*,,..
((((((#####%%%&&&%%%%%&&&&&&&&*/*&&&&&%% %&&@@@@&&&%%%%%##%#((#%#(#%%#((/(###(((
((((((##%%%%%%%%%%%%%&%&&&&&&&,*,&&&##%%%#%&&&&&&%%%%%%%#######(###%%%#((/****,.
//((((((#%%%%%########%%#(##&&%#%%%(/%%#%%%%%%%%%#%%%%%%########(//((#((/**,,,,,
((//////((####((((((((((/////((((//((##(##(((%%#///#%%%###(((((((####((//**,,...
//////////((###(/////////****/(//////((#////#((/*,*(#%###((///////(####(((//*,. 
///*******///(((/******,,,****/(/(*//(//*/#(///,,.*/((((//**////((((((((//(////*
////////**////(((////*,,***/*//////**/**/**///,,,,,,,****,**////////((////**,,..
///********,,,,,,,,,,,,,,,***,,,,,,,,,. .............,,*,,,...,,*********,,..   
//******,,,,,,,,...................... ..........  ,.,*... .,..**,**,,,,...     
///******,,,,,,,,,,................             . ... .. .... . ...,,,....      
*************,,,,**,,,,,,,,,,,,...,,.....   ...      .       ..  .,.....        ";
        string _12 = @"
((/////////(((##%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&##((/****,,,,
/////////((##%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%((//****,,*
/////(((##%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%#/****
//((###%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%&&&&&&&&&&&&&%%&&%%#*,,,,
((###%%#####%%%%&&&&&&&&&&&&&&&%%&&(//&&%&&@@@@&&&&&%%%%%%%&&((#%&&&&&%%%%##/*,,
(###########%%%&&&&&&%&&&&&&&&%(%/#%&&&&&&&@@@@@&&&&%%%%%%###&#/%%(#%&%####((//*
##((((####%%%%%%%&&%%&&&&&&&&&&/*%&&&%#/( &&&&@@&&&&%%%%%#####(/(#&%%#((///**,,,
((((((##%%%%%%%%%%%%%%%%&@@@@@@**/&&##%%%#%%%&%&&%%%%%%%%######(*/(#%%%(/(#(/,,.
(((((((((#%%%##(#########((%%&&%#%#(((%#%%%%%%%%%((#%%%%%##########(((((///////*
(////////((#%##((/((//((/////(((/(##((#(#///(#%#(**(#%%###(((((((/(####((//**,..
/////***///((##(//*****//***///(/(///(((////#(/(*,,/(####((////////(((##((((/*,.
////*******//(((//******,,**/*///(////////((**/*,.,*/(((//****//////(((////****,
//////******///((/////*,***/**////***/////**//*,..,*******,**////((((((///*,,.. 
////***********************//**********  ***,,,.....,..,*****************,,...  
///*****,,,,,,,,,.....................  .........,,,........,,**,******,....    
///*******,,,,,,,,,,................             .. .   .....,.,..,,,,,....     
//*************,,***,,,,,,,,,.,..........     ..  ....      .,. .....,.....     ";
        string _13 = @"
((((/((////(((#%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%#((/****,,,,
////////(((##%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%(///****,,(
/////((###%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%(/***(*
//((###%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%&&&&&&&&&&&&&&&&&(*,,,,*
((###%%####%%%%%&&&&&&&&&&&&&&&%%&&(//&&%%&@@@@&&&&&%%%%%%%&&%(/#%&&&&&&%%#/**,.
(###########%%%&&&&&&%%&&&&&&&%(%/#%%&&&&&&@@@@@@&&&%%%%%%###%%/(&%(#%&%#####(//
##((((####%%%%%%%&&%%&&&&&&&&&&/*(&&&%#*( %&&&@@@&&&%%%%%#####((/(&%%#((//**,,,,
((((((##%%%%%%%%%%%%%%%%&@@@@@@***&%##%%%##&%&%%&%%%%%%%%#####((///#%%%(///##/*,
(((((((((#%%%##((##########%%&&%%##(((###%%%%%%%%((#%%%%%##########(((((//****/*
((///////((#%##((/((//((////*(((//(##(#(#///(#%#(**/#%%###(((((((/((###((//**,..
/////***///((##(//*****//****//(/((///((////#(/(/,,*(####((///*////(((#((#((/*,.
///********//(((//******,,**/*//((/*//////((/*//,..*/(((//****////////(///*****,
///////*****///((////**,,*****////****////***/*,..,*******,,*////((((((///*,,...
////**************//******///**********. *//*,,,....,...,/*********,*****,,...  
///*****,,,,,,,,,,....................  ...........*,,.,,*,,*/(*,,*****,....    
///******,,,,,,,,,,..................     .      .  ..  .......,.,*,,,,....     
**************,,,,*,,,,,.,.,,............      .  ....     ..,. .....,....      ";
        string _14 = @"
(((((((((((((##%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%((//***,,,,
//////((((##%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%#//(**/*,*(
////((###%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&#(/**/#,
/(((##%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%&&&&&&%&&&&&&&&&%/,,,,**
((###%%####%%%%%&&&&&&&&&&&&&&&&%%%(//&&&(&@@@@@&&&&&%%%%%%%&&(/(%&&%%%%%#/**,,,
(###########%%&&&&&&&%%&&&&&&&&(%(%%%&&&&&@@@@@@@&&&%%%%%%%#(%%(/&&##%&&%#%%%%#(
###((#####%%&&%%%&&&&&&&&&&&&&&//*&&&%#/# #&&&&@@&&&%%%%%######(/(%&%%((//**,,,,
((((((###%%%%%%%%%%%%%%%&@@@@@@***&%#(%&%#(&%&%%&%%%%%%%%%#####(///#%%%#/*/(((/*
(((((((((#%%%##((##########%%&&&%#%(%(###%%%%%%%%#(#%%%%%###(#######((((//****/*
((///////((#%##((((((/(((///*/((//((#(###(//((%#(/*/#%%###(((((((/(####((///*,..
/////**////((##(//*****///***/((/((///((////((/(/*,*/####((////////(((#####(/*,.
///********//(((//*******,******((/*////*/((/*//,..,/((((//***////////(////****,
/////********///(////**,,,****////****////***//,. ,*******,,**///((((((///*,,...
////*************////*******************.*/#(,.,........,*///*,,*********,,...  
//*****,,,,,,,,,......................   ...........,,**.,//(#*..,,***,,...     
*******,,,,,,,,,,..................                 ... .  .. ...**,,,,...      
********,,,,,,,,,,,,,.................             ..      ...   ....... .      ";
        string _15 = @"
((((((((((((((##%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@&&&&&&&&&&&%%((//****,,,
//((((((((##%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@@@@@@@@@&@@@@@&&&&&%#(///**/*,/
////(((##%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&@&&&&&&&&&&&&@@&&&@@@&@@&&&&&&&&&%#/***/
//((##%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&@@@@@&&&&&&&%%%%@&&&&&&&&&&&&&&&%%%/,,,,
(((##%%%%%%%%%%%&&&&&&&&&&&&&&&&%%&&%&&&&&&@@@@@&&&&&&%%%%%&&(((%%&&&&&&&&%#/*,,
(###########%%%&&&&&&&%&&&#&%&&%%((%(#%&&&@&@@@@@&&&%%%%%%%##%%/%&((%&%###((////
##########%%&&&&%&&&&&&&&@@@@@@(//&&&&%##.%&&&&@@&&&&%%%%%#####/(#&%#%#(((/**,,,
((((((###%%&&%%%%%%%%%%%&@@@@@@#**&&%#(%%#/(&&&%&&%%%%%%%%#####(///#%%%#((%#/*,,
(((((((((#%%%%#########%##&&%&&,%%%(%(#%%#%%%%%%%%((%%%%%##########((((((//((//*
(((//////((#%%##((((((((((////(((((#%##(%#(((#%%#(**(#%%###((((((/(##%#((///**,.
///////////(###(/////***/(***/(/(/#(//((//(((#(/(***/(####((//////(((#####((/**,
/////******//((((/***********/*/(/(*//////#(/*/(/,.,*/##((//*/////////(((//////*
//////*******///(////***,,*****///*****///**/*/*,..,*////*****///(((((((///*,,..
//////*********///////*************,********//*.,,..,,,,,,,,*///******/****,... 
//******,,,,,,,,,,.........,,,,,........  ..............//**/....,***,,,,...    
********,,,,,,,,....................      ....        *..  .  , .,*,,,....      
********,,,,,,,,,,,,,...............              ..,. .  ....   .........      ";
        string _16 = @"
((((((((((((((##%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%#((//****,,,
/(((((((((###%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@@@@@@@@@@@@@@@&&&&&&%(//(****,*
///((((###%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@@&&&@@@@@@@@&&&&&&%&&%(/**/
//((##%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&@@@@@@&&&&&&%%%&@&&@&&&&&&&&%%%&%#%#/,,,
(((##%%%%%%%%%%%&&&&&&&&&&&&&&&&&%&%%%&&&&&@@@@@&&&&&&%%%%%&&(((%&&&&&&&&%%##/*,
(###%#######%%%&&&&&&&&&%&#&#&&%##(%#/&&&&&&@@@@@&&&&%%%%%%##&#/&&((&&%###(((##(
###########%%&&&&&&&&&&&&@@@@@@%(/#&&&&##/%&&@&@@&&&&%%%%%####(((%%##%##((((//*,
(((((####%%&&%%%%%%%%%%%&@@@@@@&**%&&#(%%#.(&&&%&&%%%%%%%%######//(%%%%%#%#(/*,,
((((((((##%%%%%########%%#&&%&&*&%(#%##%%#%%%%%%%&((%%%%%%#########((##(((/((/**
((((/////((#%%##((((((((((////(##((###((%#(#(##%##//(%%%%##(((((((##%%#(((/**,,.
///////////(####(/////**/(/**/(((/##//((/((((##/(/**/(####((//////((######((/**,
//////***////((#(/***********/*/(/(*//////#(/////,.,*/##((////////////((((/////*
///////******//(((///***,,******///****/////////,..,*////*****///((((((((//**,,.
///////********////(//******/***/***********//*,.,,,,,,,,,,,**********/****,....
///*****,,,,,,,,,,,,,,,,,,,,,,,,,,...,..  .............../,*.....,***,,,,,...   
//******,,,,,,,,,....................    ........   ...*,.   .. .,,,*,,....     
********,,,,,,,,,,,,,...............              . ,.. .  ...   .........      ";
        string _17 = @"
(((((((((((((###%%%&&&&&&&&&&&&&&&&&&&@@@@@@&@@&&&@@@@@@@@@@@@@@&&&%#(((/*****,,
(((((((((((##%%%&&&&&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&%&%#(///****,
///((((###%%%&&&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&&&&%%&#//*
//(((##%%%%%%%%&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@&&&&&&&@@@@@&&&%&&&&%###%%/((#/,
(((##%%%%%%%%%%%&&&&&&&&&&&&&&&&&%&&&&@@@@@@@@@@&&&&&&%%%%%&####%&&&&&&%%#((#((/
(###%%######%%%&&&&&&&&&&&&&#&&&#&#&&#%&@@&@@@@@@@&&&&%%%%%#%&(%&(#&&%%#%%%%(/*,
###########%%&&&&&&&&&&&&@@@@@@&(//&&&&%#*%&@@@@@@&&&%%%%%##%#((#&(/#%%%%%%%#((/
((((((###%%&&%%%%%%%%%%%&@@@@@@@**(&&%(%&# #&&&%&&%&&%%%%%%#####//#%%%%&%%%%#((/
((((((((##%%%%%########%%%&&%&(*%%,%#%#%%%%%%%%%%&#(%%%%%%########((((##((((/*,,
((((/////((#%%###((((#(((#(///###(##########(%#&%#//(%%%%###((((((##%%#((//**,,.
///////////(####(//////*///**/(((/#%((/#(((/((#((/**/(####(((/////((###%#(((//*,
//////***////((#(//******/**///((/(////////((///(*,,*/(##((///////////((((((///*
///////******//(((////**,,******////***//////*//,,.,*/////*****//((((((((//**,,,
/////////*****////((//*,,***/**//*****//*****/*,..,,,,****,,******////////**,...
////******,,,,,,,,,,,,,,,,,***,,,,,,,,,,  .............,,./..,.,,***,,*,,,,...  
///******,,,,,,,,,..................... .............,*,//,,,*...*.***,,....    
*********,,,,,,,,,,,,...............              . ..  .. .,  . ..,,,......    ";
        string _18 = @"
((((((((((((((###%%&&&&&&&&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&##((/*****,,
((((((((((((##%%&&&&&&&@@@&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&%%#(///*****
////((((###%%%&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&@@@&&&&%%%%%%%%(/*
//(((##%%%%%%%%&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&&@@@@&&&@&&&&&%%##((#/(*/(
/((##%%%%%%%%%%%&&&&&&&&&&&&&&&@&&&&&&@@@@@@@@@@@&&&&&%%&%&@&&##&&&&&&&&&%#(((//
((##%%%#####%%%&&&&&&&&&&&&%%&@&#&#&##/&&@@&@@@@@@&&&&&%%%%%&%(&%(&&&%%&&&#/**,,
###########%%&&&&&&&&&&&&@@@@@@@///&&&&%##(&@@@@@@&&&%%%%%%#%#((%%//#%%%&%%%##/*
(((((####%%&&&%%%%%%%&%%&@@@@@@@***&&%(%&% #&&&%&@&&&%%%%%%#####/(#%%%%&%%%%#(/*
((((((((##%%%%%%######%%%&&&&&/(%%,%%%#%%%%%%%%%%&#(%%%%%%%#####(#(/((###((/**,,
((((/////((#%%%##((((#(((#(///##%###########(##&%#(/(#%%%###((((((##%%#(((/**,,,
(//////////(####(//////*////*/(((/(%((/##((/((#((/**/(#%##(((////(((###%#(((//*,
//////***////((#(//******/**///((/(//(/////(((//(*,,*/(##((///////////((((((((/*
///////******//(((////***,******////***/////////*,.,*/////*****//((((((((///**,,
/////////*****////((//**,***/**//*****//*****/*,..,,,,****,,,*****////////**,...
////*******,,,,,,,,,,,,,,,,***,,,,,,,,,,. .............,,./..,.,,***,,***,,...  
///******,,,,,,,,,..................... .............,*,//,,,*...*.***,,,...    
**********,,,,,,,,,,,................             . ..  .. .,. . ...,,,.....    ";
        string _19 = @"
((((((((((((((###%%&&&&&&&&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&##((/*****,,
((((((((((((##%%&&&&&&&@@@&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&%%#(///*****
////((((###%%%&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&@@@&&&&%%%%%%%%(/*
//(((##%%%%%%%%&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&&@@@@&&&@&&&&&%%##((#/(*/(
/((##%%%%%%%%%%%&&&&&&&&&&&&&&&@&&&&&&@@@@@@@@@@@&&&&&%%&%&@&&##&&&&&&&&&%#(((//
((##%%%#####%%%&&&&&&&&&&&&%%&@&#&#&##/&&@@&@@@@@@&&&&&%%%%%&%(&%(&&&%%&&&#/**,,
###########%%&&&&&&&&&&&&@@@@@@@///&&&&%##(&@@@@@@&&&%%%%%%#%#((%%//#%%%&%%%##/*
(((((####%%&&&%%%%%%%&%%&@@@@@@@***&&%(%&% #&&&%&@&&&%%%%%%#####/(#%%%%&%%%%#(/*
((((((((##%%%%%%######%%%&&&&&/(%%,%%%#%%%%%%%%%%&#(%%%%%%%#####(#(/((###((/**,,
((((/////((#%%%##((((#(((#(///##%###########(##&%#(/(#%%%###((((((##%%#(((/**,,,
(//////////(####(//////*////*/(((/(%((/##((/((#((/**/(#%###((////(((###%#(((//*,
//////***////((#(//******/**///((/(//(/////(((//(*,,*/(##((///////////((((((((/*
////////*****//(((////***,******////***/////////*,.,*/////*****//((((((((///**,,
/////////*****////((//**,***/**//*****//*****/*,..,,,,****,,,*****////////**,...
////*******,,,,,,,,,,,,,,,,***,,,,,,,,,,. .............,,./..,.,,***,,***,,...  
///******,,,,,,,,,..................... .............,*,//,,,*...*.***,,,...    
**********,,,,,,,,,,,................             . ..  .. .,. . ...,,,.....    ";
        string _2 = @"
%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%######(((((//////////////////***///////
%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&%%%%%%%##(((((((////////***//**/**///**********
#%%%%%%%%%&&&&&&&&&&&&&&&&%%%&&&%%#########((((///**/////***********************
##%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%##((((((((((((///******************************
#%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%%###((((/(((////*********************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#####((((/(///////*****************,,,***,**,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%###((//////***////*******,,,,***,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##(//////*************,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%####((//////*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%#########(((///*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%######(((((////*********,******,,,,,,,,,,,..,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%%%%####((((////****************,,,,,,,,,,,,,............
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%####(((///*********,,,,,,,,,.,,,,.........,,
%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&%%%%%%%%%%%##((((//*****,,,,,,,,,.........,,,,
%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&%%%%%%##%%%%%%%##(///***,,,,,,,,...,,,,,,,
&&%%%%&&&&&%%%%%%##%%%%%%%%%%%%%%%%&&&&%%##//*/######%%%%%%%%##((/***,,,,,,,,,,,
@@@@&&&&&&&&&&&&&&&&&&&%%%%%%###########%##%%######((##%%%&%%%%%%%%%##((///****,";
        string _20 = @"
(((((((((((((((##%%&&&&&&&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&%#((/*****,,
/(((((((((((##%%&&&&&&&&&@&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&%%#(///**,*,
/////((((##%%%&&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&@@&&&&&%%%%%#%%(/*
///(((##%%%%%%%%&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@&&&&&&&@@@@&&&@&&&&&%%#(((#/(**(
/(((##%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&@@@@@@@@@@@&&&&&%%%%&&&%%#&&&&&&&&&%#(((//
((###%#######%%%&&&&&&&&&&&%%&@&#&#%(%/&&@&@@@@@@@&&&&%%%%%%%&(&&(&&&%%%&&#/**,,
(###########%%&&&&&&&&&&&@@@@@@@///&&&&&#%,&@@@@@@&&&%%%%%##%#((#&/*(%%%%%%%%#/*
(((((((##%%&&%%%%%%%%%%%&@@@@@@@***&&%(#&%.#&&&%&&&%%%%%%%######//#%%%%&%%%%#(/*
(((((((((##%%%%%#######%%%&&&&/%/&/%##(#%%%%%%%%%%#(#%%%%%######(#(/((###((//*,.
((((//////(#%%%#(((((#(((((///(#%###(##(####(##%%#(//#%%####(((((((##%#(((/**,,,
////////////(###(//////*///***/((/(##(/(#((/((#(//***/####(((/////(((####(((//*,
//////*****//((#(//**********///((/(///////(((//(*,,*/(##((////////////(((((((/*
//////*******///((///****,******////****////////*,..**////*****///((((((///**,,.
///////********///////**,******/*/*****/*****//*..,,,,,***,,,*****////////**,...
///******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,. ................/.....,,,**,,,,,,...  
/********,,,,,,,,....................... ..........  .,./**..,,..**,**,,,...    
*********,,,,,,,,,,,,,...............             ........ ...    ...,,.....    ";
        string _21 = @"
(((((((((((((((##%%&&&&&&&&&&&&&&&&@@@@@@@@&&&@@@@@@@@@@@@@@@@@&&&&&%#(//******,
/((((((((((((#%%&&&&&&&&&@&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&@&&&%#(///**,**
/////((((##%%%&&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&@@&&&&&%%%%%#%%#/*
///(((##%%%%%%%%&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&&@@@@@&&&&&&&&&%#(((#((/*/
/(((##%%%%%%%%%%&&&&&&&&&&&&@&&&&&&&&&&@@@@@@@@@@&&&&&%%%%&@&&%#&&&&&&&&&%#(((//
((###%#######%%%&&&&&&&&&&&%&&&&#%%%(%/%&@&@@@@@@@&&&&%%%%%%%&(&&#&&&%%&&%#/**,,
(###########%%&&&&&&&&&&&@@@@@@@/(/&&&&&#%,&@@@@@@&&&%%%%%##%%((#%/*(%%%%%%%%%(/
(((((((##%%&&&%%%%%%%%%%&@@@@@@@***&&&##&%,#&&&%&@&%%%%%%%######((#%#%%&%##%#(/*
(((((((((##%%%%%#######%%%@&&&(&/&*%%##%%%%%%%%%%%%(#%%%%%######(#(/((####(/**,.
((((/////((#%%%#(((((#(((((//(#%%###(####(##(##%%#(//#%%%###(((((((##%#(((/**,,.
///////////((###(//////*////**/((/(##((##(//((##(/***(#####((/////(((####(((//*,
//////****///((#((/******/***//(((/(////////((//(/,,*/(##((////////////(((((((//
/////********//(((///****,******///(***/////(///*,..,*/////****///((((((////**,,
///////********///////**,******/*/*****/*****//*,..,,,****,,,*****/////////*,,..
////******,,,,,,,,,,,,,,,,,,***,,,,,,,,,,  .............,.,,.,,,,,,*,,,**,,.... 
/*******,,,,,,,,,,.....................  .............,,,**,,,,..*,,**,,,...    
*********,,,,,,,,,,,,,...............              . ... .. .. . ....,,.....    ";
        string _22 = @"
&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@&@@@@@@@@@&&&&&@@@@@@@@@@@@@@@@@&&&&&%#/(///*****
((((((((((((((##%%&&&&&&@@&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&%%##//***,,,
//////(((((##%%&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&@@@@@&&&%%%##((((((*
/////(((##%%%&&&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@&&&&&&&@@@@@&@%#&@@@@&&%##(//((/,
///(((##%%%%%%%%%&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@&&&&&%%&&&&&&%@@&&&&&&%%#(/((/*
/(((##%%%%###%%%%&&&&&&&&&&&&&&@&%%&&%&#&&@@@@@@@@&&&&&%%%%%&#%&&&&&&&&&%%(***,,
((###########%%&&&&&&&&&&&@@@@@@%((/(#&&&&&@@@&@@@@&&%%%%%%%%#((%#(#%&&%#(/(#%%%
(###(((###%%%&&%%%%&&&&&&@@@@@@@&//(&&&%%/( %&&&&@&&&%%%%%%#######%#(%&%%##((//*
((((((((###%%%%%%###%%%%%%@@@@@@@**/&%##&%%%%%%&%%&##%%%%%%#######(//(####(/*,,,
(((((((((((##%%%#((##(#(##((#%%&&&%######(#%##%%%%%//(%%%####((((((#%%##((//*,,,
(((/////////(##%#((/((////////*(((/(##((##(///(##(/**/(#%##((((///(((#####(((/**
//////////////(##(//*****///**//((/((///((////(//(*,,*/###((///////////((((((((/
//////*******///(((/*******,*****/((/***////(//*/*,..**(((//****///((((((////**,
/////////*******////////*,,*****///*****/**/**//*...,*******,,**/*//////////*,,.
//////***********************************. .*,,,,......,..*,***,***,,*,***,,,...
///******,,,,,,,,,......................   .........,,.. .. ...,./**,,*,*,...   
**********,,,,,,,,,,,.................              ....  .. ..,. ...,,,,....   ";
        string _23 = @"
&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@&@@@@@@@@@&&&&&@@@@@@@@@@@@@@@@@&&&&&%#/(///*****
((((((((((((((##%%&&&&&&@@&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&%%##//***,,,
//////(((((##%%&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&@@@@@&&&%%%##((((((*
/////(((##%%%%&&&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@&&&&&&&@@@@@&@%(&@@@@&&%##(//((/,
///(((##%%%%%%%%%&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@&&&&&%%&&&&&&%&@&&&&&&%%#(/((/*
/(((##%%%%###%%%%&&&&&&&&&&&&&&@&%%&&%&#&&@@@@@@@@&&&&&%%%%%&#%&&&&&&&&&%%(***,,
((###########%%&&&&&&&&&&&@@@@@@%((/(#&&&&&@@@&@@@@&&%%%%%%%%#((%#(#%&&%#//(#%%%
(###(((###%%%&&%%%%&&&&&&@@@@@@@&//(&&&%%/( %&&&&@&&&%%%%%%#######%#(%&%%##((//*
((((((((###%%&%%%###%%%%%%@@@@@@@**/&%##&%%%#%%&%%&##%%%%%%#######(//(####(/*,,,
(((((((((((##%%%#((##(#(##((#%%&&&%######(#%##%%%%%//(%%%####((((((#%%##((//*,,,
(((/////////(##%#((/((////////*(((/(##((##(///(##(/**/(####((((///(((#####(((/**
//////////////(##(//*****///**//((/((///((////(//(*,,*/###((///////////((((((((/
//////*******///(((/*******,*****/((/***////(//*/*,..**(((//****///((((((////**,
/////////*******////////*,,*****///*****/**/**//*...,*******,,**/*/////(////*,,.
//////***********************************. .*,,,,......,..*,***,***,,*,***,,,...
///******,,,,,,,,,......................  ..........,,.. .. ...,./**,,*,*,...   
**********,,,,,,,,,,,.................              ....  .. ..,. ...,,,,....   ";
        string _24 = @"
&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&%%%(////******
(((((((((((((((##%%&&&&&&&&&&&&&&&@@&@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&%%%#(//***,,,
///////(((((##%%&&&&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&@@@@@@&&&%%###(((((/*
//////(((##%%%%&&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@&&&&&&&@@@@&&&%%&@@@&&&%#(///(#*,
////((##%%%%%%%%%%&&&&&&&&&&&&&&&&@@@@@@@@@@@@@@@&&&&%%%&&&&&&&&&&&&&&&%#(//(//*
///((##%%####%%%%&&&&&&&&&&&&&&&&%%%&%&&@@#@@@@@@@&&&&%%%%%%##&&&%#%%&&%%#(**,,,
/((###########%%&&&&&&&&&&&%&%&&%((/((##&&@@&@@@@@&&&%%%%%%%%((#%###%&%#(/(####%
((###(((####%%&%%%%&&&&&&&@@@@@@&//%&&%%((..%&&%&@&%%%%%%%#########(#&&%#((//*/*
(((((((((##%%%%%%###%%%%%&@@@@@@@**(%%(#%%%(%%%&%&&#%%%%%%######((///(####/**,,,
/((((((((((#%%%##((##(((##(%&%&&((%((#%#(((####%%#%//#%%%###((((((##%#((((/**,,,
/((////////((#%##((//(//(((/**/(((((###(##(//((##(/**/(####(((///((/(####((///*,
///////***///((#(//******///**//((/((/////////(//(*,,*/###((/////*////((((((((//
//////*******//(((//*******,**/*///(***/*//(//**//,.,*/(((//****///////(////***,
//////*********///////***,,******/*******//****/*...,*******,,*////////////**,,.
//////************/////*******************,*///*.,,...,,,,,,*//***********,,,...
///******,,,,,,,,,,,.....................  .............,/,,,**,...,****,,...   
********,,,,,,,,.....................       ...        ,. . ..  . .,*,,,....    ";
        string _25 = @"
&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&%(//*/*****,
((((((((((((((((##%%&&&&&&&&&&&&&&&&&&&&@@@@@@@@&@@@@@@@@@@@@@@&&&&%%##(/***,,,,
/////////((((##%%&&&&&&&&&&&&&&&&@&@@@@@@@@@@@@@@@@@@@@@@&&&@@@&&&&&%%%####%#(/*
///////(((##%%%%%&&&&&&&&&&&&&&&&@@@@@@@@@@@@@&&&&&&&&@@@&&&&%#%&@&&&%#((/((/**/
/////((##%%%%%%%%%%&&&&&&&&&&&&&&&&&&&@@@@@@@@@@&&&&&%%%&&&&&%%&&&&&&&&&%#((((//
*///((##%%####%%%%&&&&&&&&&&&&&&&&%&&#%#&&&&@@@@@@&&&&%%%#%%%(#&&%&&&&&&&%(/*,,,
//((###########%%&&&&&&&%%&&#%&&&(#/##((&&@@&@@@@@&&&%%%%%##%#((%#//#%&%%#((###/
/((##(((((###%%&%%%%&&&&%&@@@@@@@///&&%#(/( #&%&&@&%%%%%%%######((%###%%%####((/
(((((((((##%%%%%%%####%%%%&@@@@@@***&%#(%%%#(%%%%%&##%%%%%######(((//((##((//*,,
///(((((((((#%%%##((##(((#(#&&%&&(%##(%#(((##(#%%%#(/(#%####(((((((##%#(((//*,,.
//(/////////((###((///(/////***/((/(###(#((//((##(/***(####(((////((((####////**
///////*****//((((/*******//***//((/(/////*/////*//,,*/(##((////****////(((/(///
/////*********//(((/*******,,*****(//******/(//*//,..,*/((//*****////(/((///**,,
/////***********//////***,,,,*****/************/*,. .******,,,,*///////////**,,.
//////*************/////*************,****,,*/(*..,........,*/**,,,**,,,**,,,...
///******,,,,,,,,,.......................   ...........,./,.*///*,..,,**,,...   
********,,,,,,,,.....................                  ,.  .  .. ...,*,,,...    ";
        string _26 = @"
&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@@@&&&@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&&%(//*/*****,
((((((((((((((((##%%&&&&&&&&&&&&&&@@@&&&&@@&@@@@@@@@@@@@@@@@@@@@&&&%%%#(/****,*,
/////////((((##%%&&&&&&&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@@&&@@@&&&&&&%%%#%#%#(/*
///////(((##%%%%%&&&&&&&&&&&&&@&@@@@@@@@@@@@@@@&&&&&&&&@@&&&@%#%&@&&&%#((/(///*/
*////((##%%%%%%%%%&&&&&&&&&&&&&&&&&&&&@@@@@@@@@@&&&&&%%%&&&%&%%&&&&&&&&&%#((((//
*///((########%%%%&&&&&&&&&&&&&&&&%&&#%#&&@&@@@@@@&&&&%%%%#%&(#&%&&&&&&&&%(**,,,
//((##########%%%&&&&&&&&%&&(&&&&(#/((/#&&@@&@&@@@&&&%%%%%##%#((%#*/%&&&%#(((#%/
/((##((((####%&&%%%%&%%&%&@@@@@@@///&&%#(/( #&%%&&&%%%%%%%######(#%#(%%%%####((/
((((((((((#%%%%%%#####%%%%&@@@@@@***%%#(%%%#(%%%%%&##%%%%#######((///(###((/**,,
///(((((((((#%%%##((##(((((#%&%&&#%##(%#(((##(#%%%#//(#%####(((((((##%((((/**,,.
////////////((####(/////////***/((/(###(#((//((##(/***(####((/////((((###(////*,
////////****//((((/*******//***//((/(/////*/////*(/,,*/(#(((////****///((((/(///
/////*********//(((/*******,,*****(//******///**//,..,*/((//*****///////(///**,,
////************//////***,,,,******************/*.. .******,,,**///////////**,,.
/////**************/////*************,****,,*//*..,......,,,,/(/*/********,,,...
///******,,,,,,,,,.......................   .............*,,,***...,,**,,....   
********,,,,,,,,.....................       ..         .. .     . .,*,,,....    ";
        string _3 = @"
%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%#####((((((///////////////////***///////
%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&%%%%%%%##(((((((////////****/**/****/**********
##%%%%%%%%&&&&&&&&&&&&&&&%%%%&&&%%##########(((///***////***********************
##%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%##((((((((//((///******************************
#%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%%###(((((///////********************,,,,,********
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#####(((((////////***************,,,,,,,,,,*,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%###(/////**************,,,,,,***,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%###(/////*******,,****,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%####(((////*/*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%#########((((//********,,,*,,,,,,,,,,,,,,,....,.,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%######((((/////***************,,,,,,,,,,..,,.......,....
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#####((((/////***********,,,,,,,,,.,,............
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##((/////*****,,,,,,,,................
%%%%%%%%###%%%%&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%%%%###((/******,,,,,,,,...........
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%%&&&&&%%##(/((###%%%%%###((/***,,,,,,,,,,,,,,,
&&&&&%%%%%%%%%%%%%%%%%%%%%###########%%%%%#((//(###(/(#%%%%%%%%%#((//******,,,,,
@@@@@&&&&&&&&&&&&&&&&&&&%%%%%##(####((((((((##(#####(###%&&&%%%%%&%%%%##((//****";
        string _4 = @"
%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%#####((((((///////////////////*/*///////
%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&%%%%%%%##(((((((////////****/**/****/**********
##%%%%%%%%%&&&&&&&&&&&&&&%%%%&&&%%##########((////***////***********************
##%%%%%%%%%%%%%%%%%%%&&&&%%%%%%%%##(((((((///((///******************************
#%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%%###(((((///////********************,,,,,********
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#####(((((////////***************,,,,,,,,,,*,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%###(/////**************,,,,,,***,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%###(/////*******,,*,**,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%###(((////*/*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%#########((((//********,,,*,,,,,,,,,,,,,,,....,.,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%######((((/////***************,,,,,,,,,,,.,,.......,....
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#####((((/////***********,,,,,,,,,.,,,...........
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##((/////*****,,,,,,,,................
%%%%%%%####%%%%&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%%%%###((/******,,,,,,,,...........
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%%&&&&&%%##(/((#%#%%%%%###((/***,,,,,,,,,,,,,,,
&&&&&%%%%%%%%%%%%%%%%%%%%%###########%%%%%#((//(###(/(#%%%%%%%%%#((//******,,,,,
@@@@@&&&&&&&&@&&&&&&&&&&%%%%%##(####((((((((##(#####(###%&&&%%%%%%%%%%##((//****";
        string _5 = @"
%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%%###((((//////////******//***********/
%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&%%%#######((((///****************************
###%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&%%%%###((((((//////****************************
##%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&%%%%%##((((//////*********************,,,,******
#%%%%%%%%%%%%%&&&&&&&&&&&&&&&&%%%%%%%##((///////////********,,,***,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&%%%###((//*************,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%&%&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%##(////***,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%#((((//***/***,,,,,,,,,,,,,,,,,,
%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%##((/((//**,,,,,,,,,,,,,,,
%%%%%&&&&%%%%%%%%%%%&&&&&%%%%%%%%%%%%%%%%%#%%%%%&&&&&&&&&%%%##(///*,,,,,,,,..,,.
%%%%%%%%%%%%%%%%%%%%%%%%##########(((((/**/(//////(##%%%%%%%%%%##((//**,,,,,,,..
%%%%%%%%%%%%%%%%%%%#####(((((((((/*///*,,**,,,,,,,*,*/******(#%%%%%#((/**,,,,,..
%%%%%%%%%%%%%%%%%%%%%%##########(((((**,******,,,,,**********/((##%%%##((/**,,,,
&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%#######((((/////((/(/(//////(((#####((/**,,
&&&&&&@@@@@@@@@@@@@@@@@@@@@@@&&&@@@@@@@@&&&&&%%%%%%%%&&&&%%##%%%%#((/((#%%#((/**
&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%&&%%%%&&&&&&&&&&&&&%%#(##%%%%##(//
%%%%%%%%%%%%%%%%%%%%&&&&&&%%%%%%%%%&&&&&&&%%%%%%&%&&&&&&&&@@@&&&&&%%%%%%%%%%##(/";
        string _6 = @"
######%%%%%%%%%%%%%&&&&&&&&&&&&&&&%%%%######((((///*********************,*******
########%%%%%%%%%%&&&&&&&&&&&&&&&&%%%####((((//////*************,,,,,,**,,,,,***
((######%%%%%%%%%%%&&&&&&&&&&&&&&&%%%%####(((((//*********,,,**,,,,,,,,,,,,,,,,,
((######%%%%%%%%%%%%%%&&&&&&&&&&&&&&%%%%%########(/**,,,,,,,,,,,,,,,,,,,,,,,,,,,
((#######%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&%%##((##(((((//**,,,,,,,,,,,,,,,,,,,..,
(((((###%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&@@@@@@&&&%%######(/****,,,,,.,,,,,.......
(((###%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%&&&%#&&&&&&&&&%%%##(/*//*,,,,,.,,.......
(#%%%%%%%%%%%%%%%%%%%%%%%%%%##%##(#((/***/***///((((##%&&&&%%#((/***,,,.........
%%%%%%%%%%%%%%%%%%%%%%#####((((((((/***/*,,,,,..,,..,,,*,*,/#%%%%(#(/**,,.......
%%%%%%%%%%%%%%%%%##########(((///((/////**,,,,,,,.....,,,,,,,//(#%%%#(/**,,,....
%%%%############################################(///*******/**,***(###((/**,....
%%%%%%#%%%%%%%%%%&&&&&&&&&&&&@@@&&&&&&&@@@@@&&&&&%%%%%%%%%%%%(//((((((##(/**,,..
&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%&%%%&&&&&&&%&&&&&%&&&&&&&&%%%%%#####((/**,,
&&&&&&&&&&&&&&&&&&&%%%%&&&&&&&%%%%#####%%&&%%%%(%%&%&&&&&&&&&&&&&&&%%%%%###((//*
%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%###(//##%%%%%#(###(/%%%%%%%%&&&%%%%%%%%%%%###((/
###%%%%%#%%%%%%####%%%##########((((((((((/###(((///((/(########%%%%%%%%%%###((/
######################(((((((((((((((((///((/////////*////*////////((#######(((/";
        string _7 = @"
#########%%%%%%%%%%%&&&&&&&&&&&&&&%%%%#%##((((((///************,,,,,,*,,,,,,,***
(#########%%%%%%%%%%%&&&&&&&&&&&&%%%%######((//////******,,,***,,,,,,,,,,,,,,,,,
(((((######%%%%%%%%%&&&&&&&&&&&&&&&&%%%%%#####((/*********,,,,,,,,,,,,,,,,,,,,,,
(((((######%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&%%%%%%%#(/***,,,,,,,,*,,,,,,.,,.,,,,,,
(((((((####%%%%%&&&&&&&&&&&&&&&&&&&&&&&@@@@&&&&&&%%%%#((/**,,,...,,,,,.,........
//(((((#%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&%%&&&&&&&&&&&&&&%%##((/**,,,,.,,,,........
/(((##%%%&&&&&&&&&&&&&&%%%%%%%%%####(///((/**////((/(##%%&&%##(//**,,,.,,.......
(##%%%%%%%%%%%%%%%%%%%%%%######(((((/**//**,,,,,,,,..,,,*/*(%%%%#((/**,,........
%%%%%%%%%%%%%%%%%%%%%%######((((((((/((((/********,,,,,,,,,*/((#%%##(/**,,......
##%%%%%%##############%%%%%%%%%%%%%%%%%%%%%%%%%%##(((////////*,*//###((/**,.....
############%%%%%%&&&&&&&&&&@@@@@@@@@@@@@@@@@@@@&&&&&&&%%%%%%#(//((####(//*,,...
#%%%%%%%%%&&&&&&&&&&&&&&&&&@@&@&&&&&&&&&&@@@@&&@&&&&&&&&&&&&&&%%%%%%%###((/**,,.
&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%%##########(#%%%%%%#%&%%%&&&&&&&%%%%%%%%%###(//*,
%%%%%%%%%%%%%%%%%%%%%%#############((((///(//##((##(#(######%%%%%%%%%%%####(((/*
###%%%%%%%%%%%%%%###########(###(((////(///////////,/*//////(//(############(((/
##################((((((((((((///((///*****///**,,,**,*************/(#(((((((((/
#######((((((((((((((((//////////*//**********,,.,,*,,,*,,,***,,,,**//////***,,,";
        string _8 = @"
###############%%%%%%%%&&&&%%%%&&&&%%%%%%%########(//****,*****,,,,,,,,,,,,,,,,,
(((((((((((######%%%%%&&&&&&&&&&&&&&&&&&&&&&%######((///***,****,,,,,,,,,,,,,,,,
////((((((((####%%%&&&&&&&&&&&&&@@@@@@@@@@@@@@&&&%%#####(//*****,,,,,,,,,,,,,,,,
/////////((##%%%&&&&&&&&&&&&&&&&&&&&&%%&&&%%%%#%&&&&&&&%%##(/////*,,,,,,,.......
****///((##%%%&&&&&&&&&&&&&&%%%%%####((###((((//((/**/#%&&&%%#((////**,,........
*///((##%%%%%%%%%%%%%%%%%%%%%##%%%%%%%%&&&&&&&&&&%#((((/(#%%&&&&##(/(/**,,......
/(##%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&@&@@@@@@@@@@@&&&&&&&&%&%%%%%%##(//*,,.....
###%%%%%%%#%%%%%%%&&&&&@@@@@&@@@@@@&&&&@@@@@@@@@@@@@&&&&&&&&&&%%%%%%%##(/**,,...
###########%%%&&&&@@@@@&&&&&&&@@@@&&&&&&&@@@@@@@@@&&&&&&&&&&&&&&%%%%%%##((/**,,,
#######%%%%&&&&&&&&&&&&&%%%&&&&&&&&&&&&@&&&&@@@@&&&&&&&&%%&&%%&%%%%%%%##((/**,,.
####%%%%%&&&&&&&&%%%&%%%%%%%%%%&&%%&&&&&&@&&&&&&&&&&&&&&%%%%%%#%%%%%%%####((/**,
##%%%%%%%%%%&&&&%%%%%%%%%%%%%%%%%###%%#/%&&&&%########%%%%%%&&%%%%%%%%###((/***,
###########((((((((((((((((///////////*/((((////(//((/#%%%&%##%%%%%#%%#%%##(/**,
####(((((((((/////////////////*******,*****,.,*,,.,,.*./*,****/(//(((/(######(/*
###((((((((((((///////****************,,,,,,...,,,,,,...,,**,,,****/////////**,,
#((((((((((///(((////*///////********,,,,,,.,..,.,,.. ..,..,,,,,,,********,,,...
((((((((((//////////************,****,,,,... ,,............,...,,,,,****,,......";
        string _9 = @"
((////////((((((((##%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%##(//(//****,,,,,,,,,,,,,
/////////////((##%%&&&&&&&&&&&&&&&&%%%&%&&&&&&&&&&&&&&&&&&&%%%#((/*****,,,,,,...
********///(##%%&&&&&&&&&&%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%##((/*,,,......
******//(##%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%##//*,,.....
****/((#%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%#((//****,,,
//((#########%%%%%&&&&&&&&&&&%%%&&&&&&&&&&&&@@&&&&&%%%%&&&&&&&%&&&&%%%##(/****,,
(###########%%%&&&&&&&&&&&&&&%(#&&&&&&%..&&&@@@&&&&&%%%#%%%%&&%##%%%%%#((/***,,,
(((((#####%%%&&&&&%%&&&&&&&&&,(*&&&&&&&&&&&&&&&&&&&&%%%%##%#(#%%%#(#%%####(/**,.
(((((###%%&&%%%%%%%%%%%%###%%%%&&%%%%%#%%%&&&&&&&&&%%%%%%#####(/(#%%%##((/**,...
(((((((##%%%%%########%#(((##%%#%%#(/####%###%%%#%%%%%%%%#######(//(###((//*,...
(((((///((##%%##((((##((///#(##/#//(###%%#((###//(#%%%%%##(((((#####((((//****,.
((/////////(####((((///*/*//*///(/((/(((/(((((***/((((((///((##########((((/*,. 
(((//////////(((((((/**//////////////(/ /##(/**,,,,*,,*//((//(//*//((((///////*,
(////***********,,,,,,,,,,,,,,........ ....,,,,,,*.,,,,*****/(*****//*//**,,..  
////*********,,,,,,,,....,,......... .         ..  .. ..,..,,,,.,*,***,,,,...   
/////*************,,,,,,,,,............           .        .,. ...,,,,,....     
////**********,*****,,,,,,,,,,,,,,,,....   .. .              . ......,...       ";
        // https://manytools.org/hacker-tools/convert-images-to-ascii-art/go/
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WindowWidth = 80;
        Console.WindowHeight = 18;

        string[] butterfly_frames = new string[] { _1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18 };
        for (int i = 0; i < repeats; i++)
        {

            foreach (string butterfly_frame in butterfly_frames)
            {

                Console.WriteLine(butterfly_frame);
                Thread.Sleep(speed);


            }
        }
    }
    static void Family_animation(int speed =100, int repeats = 1)
    {

        string _0 = @"
******************************///////////////////////((((((((((((((((((#########################################%%%%%%%%
,,,,,,,***************************/////////////////////////////(((((((((((((((((((((((##################################
,,,,,,,,,,,,*,,,,,,,*******************************/*//////////////////////(((((((((((((((((((((((((((((################
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************************///////////////////////(((((((((((((((((((((((((((((((((
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************///////////////////////////////((((((((((((((((((((
.......,........,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************************///////////////////////////////((((((((
..............................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************************///////////////////////////
.....................................,,,,,,,,,,,,,,,/%#,,,,,,,,,,,,,******************************//////////////////////
#####/.......................................,,,,/&&&&&&&&,,,,,,,,,,,,,,,,,********************************/////////////
##########%%%#*................................,(&&&&&&&&&&*,,,,,,,,,,,,,,,,,,,,********************************//****//
#######%%%%%%%%%%%%%%%%%%%/...................,#%%&&&&&&&&/,,,,,,,,,,,,,,,,,,,,,,,**************************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#(.........../*(&&&&&&&&(,..,,,,,,,,,,,,,,,,,,,,,,,,,,**********************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%///%&&&&&&&&&,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************
##%%%%%%%########%%%%%%%%%%&&&%%%%%%%%%%%%(**%&&&&&&&&&&&%%%%&%(,,,,,,,,,,,,,,,,,,***,**********************************
##########%##%%%##############%%%%%%###%%%*/#&&&&&&&&&&&##%%%%&&&&&&&&&&%%&&%%##(//*************************************
###############################%%%%%%&%%%%**%&&&&&&&&&&&##%%%%%%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%#(/*/**********
#####%%%#%%%#############################**(&&&&&&&&&&&&%%%%%%%%%%#####%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&(/
##%%%%%#################################(,/#%&&&&&&&&&&&##(%&&@%%###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%#%##%%%%%%########%#####%%%%%%%%##**/%&&&&&&&&&&&&&%(/&&&&&&%#######%#################%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%&%%%%%%%%%%%%%%%###%%%%%%#*/#%&&&&&&&&&&&&&&//#&&&&&&&&&%%%%%%##%%%#############%######%%%%%%%%%%%%%%%%%%%%%
##%#####%%%#%%#%%########%##%%%#%%%%#(,%%&&&&&&&&&&&&&&&#*##&&&&&&&&&&&&&%%&%%%&%#%%%%%%%%&&&&&&%###########%%%%%%%%%%%%
(((((((((((((((((((((((/(((((((((((((%#&&&&&&&&&&&&&&#&&&&&&%%&&&&&&&&&&%%%%%%%&&%%%%%%%%%&&&%%%%%%%%%%%%##%#%%%%%%%%##%
#######(###%####(######%#####(#(((((((#&&&&&&&&&&&&&&&#&#(%#%%%&&&&#((((((##(########((#((((((#(############(#(#########
####(###########################%#%%###&&&&&&&&&&&&&&&%##%%##%%%%%%%(###########(####(####%%%###########%%%%%%%%%%%%%%%%
%%%%%%%%%##########(#(##############(&#&&&&&&&&&&&&&&&%###%%%%%%%%%%%####(#######%%%%%######%##%%%#####################%
&%%%%&&%%%%%%%########%#####(#######/%%&&&&&&&&&&&&&&&%##%&(%%%%%%%%%#####%%%%%%%%##%%%%%%%#%#%%%####%##%%%#%#####%##%%%
&&&&&&&&&&&&&&%%%%##%%%&&%%%%######((#&&&&&&&&&&&&&&&&&##(#/%%%%%%%%%%%&%%#%#%%%%%%%%%%%%%%%#%%%%%%%#%###%%%##%%%%%%%%##";
        string _1 = @"
******************************///////////////////////(((((((((((((((((##########################################%%%%%%%%
,,,,,,,***************************/////////////////////////////((((((((((((((((((((((((#################################
,,,,,,,,,,,,,,,,,,,,*********************************//////////////////////(((((((((((((((((((((((((((((################
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************************///////////////////////(((((((((((((((((((((((((((((((((
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************///////////////////////////////((((((((((((((((((((
...................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************************////////////////////////////////(((((((
..............................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************************///////////////////////////
.......................................,,,,,,,,,,,,,/%#,,,,,,,,,,,,,******************************//////////////////////
#####/.......................................,,,,/&&&&&&&&,,,,,,,,,,,,,,,,,**********************************///////////
###########%##*................................,(&&&&&&&&&&*,,,,,,,,,,,,,,,,,,,,**************************************//
#######%%%%%%%%%%%%%%%%%%%/...................,#%%&&&&&&&&/,,,,,,,,,,,,,,,,,,,,,,,**************************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#(.........../*(&&&&&&&&(,..,,,,,,,,,,,,,,,,,,,,,,,,,,**********************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%///%&&&&&&&&&,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************
##%%%%%%%########%%%%%%%%%%&&&%%%%%%%%%%%%(*/%&&&&&&&&&&&%%%%&%(,,,,,,,,,,,,,,,,,,,,*,**********************************
##########%##%%%##############%%%%%%###%%%*/#&&&&&&&&&&&##%%%%&&&&&&&&&&%%&&%%##(//*************************************
###############################%%%%%%&%%%%**%&&&&&&&&&&&##%%%%%%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%#(/*/**********
#####%%%#%%%#############################**(&&&&&&&&&&&&%%%%%%%%%%#####%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&(/
##%%%%%#################################(,/#%&&&&&&&&&&&##(%&&@%%###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%#%##%%%%%%########%#####%%%%%%%%##**/%&&&&&&&&&&&&&%(/&&&&&&%#######%#################%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%&%%%%%%%%%%%%%%%###%%%%%%#*/#%&&&&&&&&&&&&&&//#&&&&&&&&&%%%%%%##%%%#############%######%%%%%%%%%%%%%%%%%%%%%
##%#####%%%#%%#%%########%#%%%%#%%%%#(,%%&&&&&&&&&&&&&&&#*##&&&&&@&&&&&&&%%&%%%&%#%%%%%%%%&&&&&&%###########%%%%%%%%%%%%
(((((((((((((((((((((((/(((((((((((((%#&&&&&&&&&&&&&&#&&&&&&%%&&&&&&&&&&%%%%%%%&&%%%%%%%%%&&&%%%%%%%%%%%%##%#%%%%%%%%##%
#######(###%####(######%#####(#(((((((#&&&&&&&&&&&&&&&#&#(%#%%%&&&&#((((((##(########((#((((((#(############(#(#########
####(###########################%#%%###&&&&&&&&&&&&&&&%##%%##%%%%%%%(###########(####(####%%%###########%%%%%%%%%%%%%%%%
%%%%%%%%%##########(#(##############(&#&&&&&&&&&&&&&&&%###%%%%%%%%%%%####(#######%%%%%######%##%%%#####################%
&%%%%&&%%%%%%%########%#############/%%&&&&&&&&&&&&&&&%##%&(%%%%%%%%%#####%%%%%%%%##%%%%%%%#%#%%%####%##%%%#%#####%##%%%
&&&&&&&&&&&&&&%%%%##%%%&&%%%%######((#&&&&&&&&&&&&&&&&&##(#/%%%%%%%%%%%&%%#%#%%%%%%%%%%%%%%%#%%%%%%%#%###%%%##%%%%%%%%##";
        string _10 = @"
***************************/////////////////////////(((((((((((((((((((######################################%%##%%%%%%%
,,,*******************************/////////////////////////////(((((((((((((((((((((((((################################
,,,,,,,,,,,,,,,,,,,****************************************////////////////(((((((((((((((((((((((((((((################
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**********************************///////////////////////(((((((((((((((((((((((((((((((((
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************///////////////////////////////((((((((((((((((((((
.......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************************//////////////////////////////(((((((((
...........................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****************************///////////////////////////////
.....................................,,,,,,,,,,,%&&*,,,,,,,,,,,,,,,*******************************//////////////////////
#####(......................................,#&&&&&&&&,,,,,,,,,,,,,,,,,,,,,,*********************************///////////
###########%##/............................,(&&&&&&&&&&*,,,,,,,,,,,,,,,,,,,,,,,,**********************************//////
#######%%%%%%%%%%%%%%%%%%%%...............*(%%&&&&&&&&,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/....../*(&&&&&&&&/,.....,,,,,,,,,,,,,,,,,,,,,,,,,************************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/*/%&&&&&&&&&#,.......,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************
##%%%%%%%%#######%%%%%%%%%%&&&%&%%%%%((*(&&&&&&&&&&&%%%%%%%%%%%%#,,,,,,,,,,,,,,,****************************************
##########%##%%%##%%%#########%%%&%%#(*#%&&&&&&&&&&&%%%###%%%%&&&&&&&&&&&&&&%%%%%%%##(////******************************
###############################%%%%%%(*(&&&&&&&&&&&&%########%%%%%&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%&%%%%%%%(/**////////
####%%%%%%%#%########################**%&&&&&&&&&&&&&%%%%%%###&&&&%%%#%%%%&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%
%%%%%%%%#####%%######%###%%%########,*(%&&&&&&&&&&&&&###/(%&@@&&######%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%#####%%%%%%#########%%###%%%#%,*/%&&&&&&&&&&&&&&&&//#&&&@@@%%%##%###########%#%##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&
%%%%%%%%%%%%%%%%%%%%%%%%%%%%##%%%***#%&&&&&&&&&&&%%&&&((##%&&&&&&&&&%%%%%%#%%%%#######%###%#%#######%#%%%%%%%%%%%%%%%%%%
##%####%%###%###%########%####%%*(*%%&&&&&&&&&&&&%&&&&&#*(*&&&&&&&&&&&&&&%&%%%%&&#%%%%%%%&&&&&&&%##%%##%#####%%%%%%%%%#%
(((((((((((((((((((((((/((((((((*%*&&&&&&&&&&&&&&&%%&&&&%%%%%&&&&&%%###%&%%%%%&&&%%%%%%&%#&&&%#%%%%#%%%%%##%%%#%%%%%%%%%
#%#####(###%############%####(#((%%&&&&&&&&&&&&&&&%%%%#((%%%%%&&&&%#((((##(#(##((#(##((##(((((###############((######%#%
################################(%%(&&&&&&&&&&&&&&%%###%%%%%%%%%%%%%(#(#(#######%(###(#######################%##%%%%%%%%
%%%%%%%%%##########(#(###(########%(&&&&&&&&&&&&&&%####%#&%&&%%%%%%%%##(((######%%%%%%%#####%#######(######%#########%#%
&%%%%&&&&%%%%%########%##(####(%(&##&&&&&&&&&&&&&&%%######%#%%%%%%%%%###%%%%%%%&%%%%%%%%%%%#%#%%%%%##%%#%%######%#%%%#%%
&&&&&&&&&&&&&&&&%%##%%%%%%%%%#&%#&&#%&&&&&&&&&&&&&&&%(###(%/%%%%%%%%%%%&%#%%#%%%%%%%%%%%%%%%%%%%%%%##%##%%%%%%%%%%%#%%%#";
        string _11 = @"
***************************/////////////////////////(((((((((((((((((((######################################%%##%%%%%%%
,,,*******************************////////////////////////////((((((((((((((((((((((((((################################
,,,,,,,,,,,,,,,,,,,****************************************////////////////(((((((((((((((((((((((((((((################
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**********************************///////////////////////(((((((((((((((((((((((((((((((((
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************///////////////////////////////((((((((((((((((((((
.......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************************//////////////////////////////(((((((((
...........................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****************************///////////////////////////////
.....................................,,,,,,,,,,,%&&*,,,,,,,,,,,,,,,*******************************//////////////////////
#####(,.....................................,#&&&&&&&&,,,,,,,,,,,,,,,,,,,,,,*********************************///////////
###########%##/............................,(&&&&&&&&&&*,,,,,,,,,,,,,,,,,,,,,,,,**********************************//////
#######%%%%%%%%%%%%%%%%%%%%...............*(%%&&&&&&&&,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/....../*(&&&&&&&&/,.....,,,,,,,,,,,,,,,,,,,,,,,,,************************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/*/%&&&&&&&&&#,.......,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************
##%%%%%%%%#######%%%%%%%%%%&&&%&%%%%%((*(&&&&&&&&&&&%%%%%%%%%%%%#,,,,,,,,,,,,,,,****************************************
##########%##%%%##%%%#########%%%&%%#(*#%&&&&&&&&&&&%%%###%%%%&&&&&&&&&&&&&&%%%%%%%##(////******************************
###############################%%%%%%(*(&&&&&&&&&&&&%########%%%%%&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%&%%%%%%%(/**////////
####%%%%%%%#%########################**%&&&&&&&&&&&&&%%%%%%###&&&&%%%#%%%%&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%
%%%%%%%%#####%%######%###%%%########,*(%&&&&&&&&&&&&&###/(%&@@&&######%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%#####%%%%%%#########%%###%%%%%,*/%&&&&&&&&&&&&&&&&//#&&&@@@%%%##%###########%#%##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&
%%%%%%%%%%%%%%%%%%%%%%%%%%%%##%%#***#%&&&&&&&&&&&%%&&&((##%&&&&&&&&&%%%%%%#%%%%#######%###%#%#######%#%%%%%%%%%%%%%%%%%%
##%####%%###%###%########%####%%*(*%%&&&&&&&&&&&&%&&&&&#*(*&&&&&&&&&&&&&&%&%%%%&&#%%%%%%%&&&&&&&%##%%##%#####%%%%%%%%%#%
(((((((((((((((((((((((/((((((((*%*&&&&&&&&&&&&&&&%%&&&&%%%%%&&&&&%%###%&%%%%%&&&%%%%%%&%#&&&%#%%%%#%%%%%##%%%#%%%%%%%%%
#%#####(###%############%####(#((%%&&&&&&&&&&&&&&&%%%%#((%%%%%&&&&%#((((##(#(##((#(##((##(((((###############((######%#%
################################(%%(&&&&&&&&&&&&&&%%###%%%%%%%%%%%%%(#(#(#######%(###(#######################%##%%%%%%%%
%%%%%%%%%##########(#(###(########%/&&&&&&&&&&&&&&%####%#&%&&%%%%%%%%##(((######%%%%%%%#####%#######(######%#########%#%
&%%%%&&&&%%%%%########%##(#####%(&##&&&&&&&&&&&&&&%%######%#%%%%%%%%%###%%%%%%%&%%%%%%%%%%%#%#%%%%%##%%#%%######%#%%%#%%
&&&&&&&&&&&&&&&&%%##%%%%%%%%%#&%#&&#%&&&&&&&&&&&&&&&%(###(%/%%%%%%%%%%%&%#%%#%%%%%%%%%%%%%%%%%%%%%%##%##%%%%%%%%%%%#%%%#";
        string _12 = @"
***************************//////////////////////////((((((((((((((((((##########################################%%%%%%%
,,,********************************////////////////////////////(((((((((((((((((((((((((################################
,,,,,,,,,,,,,,,,,,,****************************************/////////////////(((((((((((((((((((((((((((((((#############
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**********************************///////////////////////(((((((((((((((((((((((((((((((((
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************////////////////////////////////(((((((((((((((((((
.......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************************//////////////////////////////(((((((((
...........................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******************************/*////////////////////////////
.....................................,,,,,,,,,*%&&#*,,,,,,,,,,,,,,,*******************************//////////////////////
#####(,....................................,/&&&&&&&&*,,,,,,,,,,,,,,,,,,,,,,*********************************///////////
###########%#%(,..........................,(%&&&&&&&&&/,,,,,,,,,,,,,,,,,,,,,,,,,**********************************//////
#######%%%%%%%%%%%%%%%%%%%%..............*(#%&&&&&&&&*,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(*....//(%&&&&&&&(,......,,,,,,,,,,,,,,,,,,,,,,,,,************************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/*/%&&&&&&&&&%%/,......,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************
##%%%%%%%%%%####%%%%%%%%%%&&&&&&%%%%((*(&&&&&&&&&&&&%%%%%%%%%%%%%/,,,,,,,,,,,,,,****************************************
#############%%%%%%%%%%########%%%%%#*(%&&&&&&&&&&&&%%%####%%%%&&&&&&&&&&&&&%%%&%%%####((((/****************************
###############################%%%%%(*(&&&&&&&&&&&&&##########%%%%%&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%&%%%%%%%%(//////////
####%%%%%%%%%#######################**%&&&&&&&&&&&&&%%%%%%#%%%&&&&&%%%%%%&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&
%%%%%%%%#####%%######%###%%#####(##,*(%&&&&&&&&&&&&&&##(/(&&@@@&######%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%
%%%%%#####%%%%%%%##%############%%,*/%&&&&&&&&&&&&&&&&&//#&&&@@@&%%##%#############%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&
%%%%%%%%%%%%%&%%%%%%%%%%%%%%%#%%***#%&&&&&&&&&&&%%&&&&/((#%&&&&&&&&&%%%%%%#%%%%#######%###%#%#######%%%%%%%%%%%%%%%%%%%%
##%%###%%################%####%*#*%%&&&&&&&&&&&&&%&&&&&%*((&&&&&&&&&&&&&&&&%%%%&&#%%%%%%%&&&&&&&%%%%%##%%####%%%%%%%%%%%
(((((((((((((((((((((((/(((((((*%*&&&&&&&&&&&&&&&%%%&&&&&%%%%&&&&&%%###%%#%%#%&&&%%%%%%&%%&&%%#%%%%#%%%%%#%%%%#%%##%%%%%
#######(###%############%####(#(%%%&&&&&&&&&&&&&&%###%###%%%%#&&%%%##(((####(###(#(##((##(((((################((#####%#%
###################(###########(#&(&&&&&&&&&&&&&&%###%#%%%%%%%%%%%%%(#(####%####%(###(###########################%%%%%%%
%%%%%%%%%%#####%####((#########(&%%&&&&&&&&&&&&&&%%######&%&&%%%%%%%%##(((######%%%%%%%#####%#######(######%#########%#%
&%%%%&&&&%%&&%########%##(###(%#&&%(&&&&&&&&&&&&&&%#######%#%%%%%%%%%##%&%%%%%%&&%%%%%%%%%%#%#%%%%%##%%%%%##%##%%#%%%%%%
&&&&&&&&&&&&&&&&%%%%%%%%%%%%##(%&&&(&&&&&&&&&&&&&&&%#####(%#%%%&%%%%%#%&##%&#%#%%%%%#%%%#%%%%%%%%%%#####%%%%%%%%%%%#%%%#";
        string _13 = @"
*****************************//////*****/***************/////***********************///******************///////////////
**********************************************,*,,,*//**,,,*****,,,,,,,***********************************************//
*************************************************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***************************************
***********************,,***,,,,,****,*****,,,,,,,,,,,,,,,,,,,******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********
(((((/******,,,,,,,,,,,,,,,,,,,,,.,,,,,...,,***********,,,*,,,,,,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**
((((((((((((((*,,,,,,,,,,,,,.....,...,,...,,,,,,,,,..,,..,,,..,,,,,,....,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
((((((((((((((#(########*..........,,........................................................,,,,,,,,,,,,,,,,,,,,,,,,,,,
(((((((((((((((((#############,...............,,,,,.........................................................,,,,,,,,,,,,
%%%%%%##(##########################(*(,.....,,,,,,,,,...................................................................
%%%%%%%%%%%%%%%%###########################%,,,,,,,,,,..................................................................
%%%%%%%%&&&&%%%%%%&&&&&&&&&%#############%%%%%%%%%###(///////,..........................................................
%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%####%%%&&&&&&&&%###(/((((((((//////*................................................
%&&&&&&&&&&&&&&&&&&&&%%%&&&&&&&&&%%%&&%%%&&&&&&&&&&%%%%################(((((((//,,*//**.....******,,,,..................
&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%&&&&&&&&&&&%%%%%%%%%%%%%%%###############((((((((///////*******,,,,,,,**********
%%%%%%%%%%%%%%%%%%&&&&&&%%%((%%&&&&&&%&&&&&%%&&%#%&&&&&&&%#&&&%%%%%%#%%%%%%%%%#######((((((((((///////******//*/////////
%%%%%%%%%%%%%%%%%%%%%%%&&&&&&((/%%#%&%&&&&&&%(#&&&&&&&&&&&&*,%%%%%###%%######%%%%##%#######((((((((((((//////((//(((((((
%%%##%%%%%%%%#%%%%%%%&&&&%%%%%%*/%&&%%%&&&&&/%&&&&&&&&&&&&%%/.(#%&&&&%%%%%%%%#%%%%%#%%%%%########(##((((((((((((((######
%%%%#%%%%%%%%%%%%&&&&&&&&%&%%%%(/#%%%%&&&&&(#%&&&&&&&&&&&&&&%#*,*/##%%((%%%%%%%%%%%%%%%%%%%###########(#################
%%%%%%%%%%%%%&&&&&&&&&&&&%%%%%%#(**%%&&&&&%*%%&&&&&&&&&%&&&&%%&%%%&&%&//#**%%%%%%%%%%%%%%%%%%%%%###########%%%%%%%%%%%%#
%%&&%%%%%%%%%&&&%&%%&&&&&&&%%%&%&&**%&%%%&%##(&%%&&&&&&&&&&&&&&&&&&&&&&&%%%%(*%&&&&%%%%%%%%%%%%%%%%%##%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%&&&&&%%%%%&&&&%#%%%&&&&&#*(%&&%%(%###%%%%%%&%%&%&&%%%%%%%%%%%%%%##/,,&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
&&&&&&&&&&&&&&&&&&&&%%&&&%%%###%&&##%%%%%%%%/#(%%%%%%%%%%%%&&&%%%%%%&&&&&&&%%%#(,*%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
#%%&&&&&&&&&&%&&&%%%%%%%%%%%%%%%%(##%%%%%%%%%%%%%%&&&&&&&&%%%%&%%%%&&&&&&&&&&%%%%###/#%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%
#########((####%#%##%%%%&&%%%%%%%##%%/((###((#%&&&&&&&&&&&&%&%&&&&&%&&&&&&&&&&%%%%%####/%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%
####%########(######%%&%%%%%%%%%%###%%*((((#%%%%%&&(%&&%%&&&&&&&&&%%&&&&&&&&&&&&%%%%%%##((#############%%%%%%&&%%%#%#%##
#######%###%%%#%%###%&&&&&&&&&%&%%%%%%%%%%%%%&&&%%%%%%%%%#((#%%%%%%%%&&&&&%&&&&&&&&&%%%%%#,(#(((((#################%%%%%
%%%%#%%%%%%##%#%#%#%%&&&&%&&&&%&#%&%%%&&&&&&&&%%&&&%#####(#%###%#%%&&&&&&&&&&&&&&&&&&&&&%%%*((((((((((((#(######((##%###";
        string _14 = @"
//////////////*******/**/*******///*******,,*****,,,*****///*,***,,,**,*************************************************
*****************************,,**************,,,,,,*//**,,,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************
************************************,******,,,,,,,,,,,,..,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,***
***********************,,***,,,,,,***,*****,,,,,,,.,,,,,,,,,,,,**,*,,,,,.....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%#/**********,,*,,,,,,,,,,,,,.,,,,,....,**********,,,,,,....,,,,,,...................,.............,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%(,,,,,,,,,,,,......,...,,......,,,,,...,,...,............................................................,
%%%%%%%%%%%%%%%%%%%&&&&&(...........,...................................................................................
%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&,.........................................................................................
%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&%/%,.................................................................................
%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&%&&&&%%%............................................................................
%%%%%%%%&&&&%%%%&&&&&&&&&&&&&&&&&&&&&&&&&%&&&%%%%%#((((((((((*....    .  ...............................................
%%%%%&%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%##(((((((((((((/,...............................................
%%%&&&&&&&&&&&&&&&&&&%%%&&&&&&&&%%%&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%%#######((/**////*,...,******,,,,..................
&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%#########((((((//////******,,,,,,,**********
%%%%%%%%%%%%%%%%%%%%&&&&%%%####&&&&&&&&&%&&%%&%%%%&&&&&&&%#%&&%%%%#%#%%%%%%%%%########(((((((((///////******//*////////(
%%%%%%%%%%%%%%%%%%%%%%%&&&&&&((*#%#%&&&&&&&&%##%&&&&&&&&&&&/,/%%%%###%%######%%%%##%#######((((((((((((/////////((((((((
%%%##%%#%%%%###%%%%%%&&&&%%%%%%**#&&&&%&&&&&(#%&&&&&&&&&&&&%(,*/%&&&%%%%%%%%%#%%%%%#%%%%%########(##((((((((((((((######
%%%##%%%%%%%%%%%%%%%%&&&%%%%%%%#/#%%%%&&&&&###&&&&&&&&&&&&&&&#/,,*(##%##%%%%%%%%%%%%%%%%%%%###########(#################
%%%%%%%%%%%%%%%&%%%%&&&&&%%%%%%#(**%%&&&&&%/#%&&&&&&&&&&&&&%%%%%%%%%%&(*(**#%%%%%%%%%%%%%%%%%%%%###########%%%%%%%%%%%%#
%%%%%%%%%%%%%%%%%%%%&&&&%&&%%%&&&&**%%%%%&%##(#&%%%&&&&&&&&&&&&&&&&%&&&&%%%%#*/%&&&%%%%%%%%%%%%%%%%%##%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%&%%%%%%&&%%%#%%%%&&&&#*(%&&%%#####%%%%%%%%%%%%%%%%%%%%%%%%%%%##/,,/%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%
&&&%&&&%%%%%%%%%%%%&%%%%%%%%###%&&#(#%%%%%%%(###%%%%%%%&&%%%%%%%%%%%%%%%%%%%%%#(*,/%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%
###%%&%&&&&&&%%&&%%%%%%%%%%%%%%%%####%%%%%%%%#%%%&&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%###(##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
#########(((###%####%%%%&%%%%%%%%####/((###((#%%&&&&&&%&&&&%%%%%%&%%%%%%%%%%%%%%%%%####//%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%
#############(####(#%%%%%%%%%%%%%###%%*((((%%%%&%&&(#%%%%%%%&&%%%%%%%%%%%%%%%%%%%%%%%%%##((############%%%%%%%%%%%#%#%##
#######%%%#%%%%%%###%%&&&&&&&&%%%%%%%%%%%&&&&&&&%%%%%%%%%((((##%%%%%%%%%%%%%%%%&&%%%%%%%%#*/#((#(#################%#%%%%
%%%%%%%%%%%#%%#%#%%%%&&&%&&&&&%%#%&&%&&%&&&&%%#%%%%######(#########%%%&&&&&&&&&&&&&&&&&%%%%//(((((((((((((#####(((((####";
        string _15 = @"
//////////////*******************//********,****,*,,,,****//*,***,,,,,,,************************************************
*****************************,,*,,************,,,,,,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************
*******************************,***********,,,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**
************************,,,*,,,,,,***********,,,*,,,,,,,,,,,,,,***,,,,,,......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%#*********,,,,,,,,,,,,,,,,,,,,,,,...,,,*******,,,,,,,,....,,,,,,..................,.............,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%((,,,,,,,,........,,...,,.....,,,,,......................................................................
%%%%%%%%%%%%%%%%%%%%&&%%%,..............................................................................................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%*........................................................................................
%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&%%%.................................................................................
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&%%%%%&%%%*...........................................................................
%%%%%%%%%%%%%%%%&%%%%&&&&&&&&&&&&&&&&%&%%%%%%%%%%%##(((((((((((,  .      ...............................................
%%%%%%%%%&%&&&&%&&&&&&%&%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%(#(((((((((((((((, .............................................
%%%%%%&&&&&&&&&&&&&&&%%%&&&&&&&%%%%&&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%########((((/////*,..*******,,,,..................
%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%&&&&&&%&&&&%%%%%%&%%&%%%%%%%%%%%%%%%#########(((((((//////*****,,,,,,,**********
%%%%%%%%%%%%%%%%%%%%%&%%%&&%%##%&&&&&&&%%%%%&&&&%#%%&&&&&&&(%&&%%%#%%%%%%%%%%%########(((((((((///////*****///*////////(
%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%/,##%%&&&&%&&&&%##%&&&&&&&&&&&#*/%&&%%%&%%%####%%%%##%#######(((((((((((//////////((((((((
%%%#####%%%%%#%%%%%%&&&&%%%%%%%/*#&&&&&&&&&&&###&&&&&&&&&&&&%%,,/%%&&%%%%%%%%#%%%%%%%%%##############((((((((#((((######
%%%%#%%%%%%%%%%%%%%%&&&&%%%%%%%%((%%%%&&&&&&%##%&&&&&&&&&&&&&&%(,,,(##%%%%%%%%%%%%%%%%%%%%############(#################
%%%%%%%%%%%%%%&&&&&&&&&&&%%%%%&%&/,%&&&&%&&&#%#%&&&&&&&&&&&&&&%%%%%%%%&((/*,#%%%%%%%%%%%%%%%%%%%##########%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%&&&&&&&%%&%%%&&&&//#%%&&&%%%%(#%%%%%&&&&&&&&&&&&&&&&&&&&%%%%#*(%&%%%%%%%%%%%%%%%%%%##%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%&&&%%%%##%%%&&&&###%&&%%%##(###%%%%%%%%%%%%%%%%%%%%%%%%%%##(,,/%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%
&&&%&&&&&&%%%%%%%%%%%%%%%%%%###%&&(##%%%%%%%%#%##%%%%&&&&%%%%%%%%%%%%%%%%%%%%%%%#*,*%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%
(###%&%&%&&&&%%&&&%#%%%%%%%%%%%%%%(##%%%%%%%%#%%%%&&&&&&&&&%%%%%%&%%%%%%%%%%%%%%%%######%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
#########(((((###(##%%%%&%%%%%%%%(#(#%/(##((((%%%&&&&&&%%&&&&%%%%&%&%%%%%%%%%%%%%%%%####*/%%%%%%%%%%%%%#%%%%%#&&&&%%%%%%
####################%%%%%%%%%%%%%%%#%%%#/(%%%%%&%&%#%%%%%%%%%%%%%%&%%%%%%%%%%%%%%%%%%%%%##(/##########%%%%%%%&%%%%#%#%#%
%%###%#%%%%%%%######%&&&&&&&&&%&%%%%%%%&&&&&&&&&%&%%%%%%%#(((((##%%%%%%%%%%%%%&&&&%%%%%%%%#**((######################%%%
%%%%%%%%%%%%%%%##%%%%&&%&&&&&%%%/%%&&%%%%%%%#(###%######(((#####((#%%%%&&&&&&&&&&&&&&&&&%%%%//(((//(((((((##(((((((#####";
        string _16 = @"
///////////////**********////***///*******,,**,*,,,*,,****//*,***,,,,*,,************************************************
******************************,,,,*************,,,,,***,,,,,,,,,,,,,,,,,,,,,,*****,,,*************,,********************
****************************//*,,,,*************,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****
************************,,,**,,,,************,,,*,,,,,,,,,,,,,*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%(********,,,,,,,,,,,,,,,,,,,,,,,,,..,*********,,,,,,,....,,,,,,.............,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%#%,,,,,,,,.........,...,,.....,,,...........................,,..............................,,,,,,,,,..,,
%%%%%%%%%%%%%%%%%%%%&&%%%/..............................................................................................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&,........................................................................................
%%%#%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&%%%,................................................................................
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&%%%%%&%%%*...........................................................................
%%%%%%%%%%%%%%%%&&%%%%%&&&&&&&&&&&&&&%&%%%%%%%%%%%##(((((((((((*  .      ...............................................
%%%%%&%%%&&&&&&%&&&&&&%&%&&&&&&&&&&&&&&&&&&&&&&&%&&&&&&%(#(((((((((((((((, .............................................
%%%%%&&&&&&&&&&&&&&&&%%%&&&&&&&%%%%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%########(((((////*,.,*******,,,,..................
%&&&&%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%&&&&&&%&&&&%%%%%%%%%&%%%%%%%%%%%%%############((((((//////*****,,,,**,**********
%%%%%%%%%%%%%%%%%%%%%&%%%&&&%%#%&&&&&&%%%%%%&&%&%%%#&&&&&&&%(&&%%%##%%%%%%%%%%########(((((((((////////****////////////(
%%%%%##%%%%%%%%%%%%%%&&&&&&&%%*,##%&&&&&%&&&&%%%(&&&&&&&&&&&&%,#&&%%%&%%%##(%%%%%##%#######(((((((((((//////////((((((((
%%%#####%%%%%%%%%%%%&&&&%%%%%%#/,%&&&&&&&&&&&%#/&&&&&&&&&&&&&%%.*%&&&%%%%%%%%#%%%%%%%%%###############(((((((#((((######
%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%#(/%%%%%&&&&&&&/#&&&&&&&&&&&&&&&%/.,*#(%%%%%%%%%%%%%%%%%%%%############(#################
%%%%%%%%%%%%%%&&&&&&&&&&&%%%%%&&&(,#&&&&%&&&&&#%&&&&&&&&&&&&&&&%%%%%%%&&%*/.#%%%%%%%%%%%%%%%%%%%%#########%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%&&&&&&&%%%%%%&&&&(((%%&&&%%%%(/%&%%&&&&&&&&&&&&&&&&&&&&&&&%%%%/%&%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%&&&%#%%##%%%&&&&%##%%%%%%%#/%(##%%%%&&&&%%%%%%%%%%%%%%%%%%##/,,%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%
&&&%&&&&&&%%%%%%%%%%%%%%%%%%###%&%##(%%%%%%%%%%##%%%%&&&&&%&&&%%%%%%%%%%%%%%%%%%##,.%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%
####%%%&%&&&&%%&&%%#%%%%%%%%%%%%%%(##%%%%%%%%#%%%%&&&&&&&&&%%%%%%&%%%%%%%%%%%%%%%%%####(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
#########(#(((###(##%%%%&%%%%%%%%##(#%/(##((((%%%&&&&&&%%%&&&&%%%&&&&%%%%%%%%%%%%%%%%####,%%%%%%%%%%%%%%%%%%%#&&&&&%%%%%
####################%%%%%%%%%%%%%%%#%%%%/#%%%%%&%&&%&%%%%%%%%&&&%&&%%%%%%%%%%&&&%%%%%%%%%##/##########%%%%%%%%%&&%%##%#%
%%###%#%%%%%%%#####%%&&&&&&&&&%&%%%%%%%&&&&&&&&&%&%%%%%%%##((((##%%%%%%%%&&%%%&&&&&%&%%%%%%#,((#(##################%#%%%
%%%%%%%%%%%%%%%##%%%%&&%%&&&&%%%/%%&%#%##%###(##########(((#####((##%%%&&&&&&&&&&&&&&&&&&%%%%/(((//((((((((((((((((####%";
        string _17 = @"
///////////////**********////***///*******,,**,*,,,*,,****//*,***,,,,*,,************************************************
******************************,,,,*************,,,,,***,,,,,,,,,,,,,,,,,,,,,,*******************************************
****************************//*,,,,*************,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********
************************,,,**,,,,************,,,*,,,,,,,,,,,,,*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%#********,,,,,,,,,,,,,,,,,,,,,,,,,..,*********,,,,,,,....,,,,,,.............,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%,,,,,,,,.........,...,,.....,,,...........................,,.........................,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%&&%%%(..............................................................................................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&,........................................................................................
%%%#%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&%%%,................................................................................
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&%%%%%&%%%/...........................................................................
%%%%%%%%%%%%%%%%&&%%%%%&&&&&&&&&&&&&&%&%%%%%%%%%%%##(((((((((((*  . ... ................................................
%%%%%&%%%&&&&&&%&&&&&&%&%&&&&&&&&&&&&&&&&&&&&&&&%&&&&&&%(#(((((((((((((((, .............................................
%%%%%&&&&&&&&&&&&&&&&%%%&&&&&&&%%%%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%########(((((////*,.,*******,,,,..................
%&&&&%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%&&&&&&%&&&&%%%%%%%%%&%%%%%%%%%%%%%############((((((//////*****,,*,**,*********/
%%%%%%%%%%%%%%%%%%%%%&%%%&&&%%(%&&&&&&%%%%%%&&%&%&%%#%&&&&&&%(&&%%##%%%%%%%%%%########(((((((((/////////*/*///////////((
%%%%%##%%%%%%%%%%%%%%&&&&&&%%%(*#%%&&&&&%&&&&%%%%(%&&&&&&&&&&&%,#%%%%&%%%##(%%%%%##%#######(((((((((((/////////(((((((((
%%%%####%%%%%%%%%%%%&&&&%%%%%%%#.%%&&&&&&&&&&%%#/%&&&&&&&&&&&&%#*.#%&%%%%%%%%#%%%%%%%%%###############((((((##((((######
%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%#%,#%%%%&&&&&&&&%(%&&&&&&&&&&&&&&%(,.*#%#%%%%%%%%%%%%%%%%%%##############################
%%%%%%%%%%%%%%&&&&&&&&&&&&%%%%&&&&,/%&&&%&&&&&&/%%&&&&&&&&&&&&&&%%%%#%%&&&**,%%%%%%%%%%%%%%%%%%%%#########%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%&&&&&%&&%%%%%%&&&&%/(%%&&&%%%%&%((&%%&&&&&&&&&&&&&&&&&&&&&&&%%#%*#&%%%%%%%%%%%%%%%%%##%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%&%&&#%%###%%%&&&%%#%%%%%%%%%(%###%%%&&&&&&&&&%%%%%%%%%%%%%%##(*,/%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%
&&&&&&&&&&%%%%%%%%%%%%%%%%%%%#%&&%##(%%%%%%%%%%%/%#%&&&&&&&&&&%%%%%%%%%%%%%%%%%%%%#,.%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%
#####%#&%&&&&%%%&%%#%%%%%%%%%%%%%%(##%%#%%%%%#%%%%%&&&&&&&&&&%%%%&%%&&&&&%%%%%%%%%%%####,%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
#########(#(((((#(###%%%%%%%%%%%%###%(#(##((((%%%%&&&&&&%%%&&&&&&&&&&&&&&%%%%%%%%%%%%%%###/%%%%%%%%%%%%%%%%%%#&&&&&%%%%%
###########(########%%&%&%%%%%%%%%%%&#%%%%&&%&&&&&&%%&%%%%%%%%%&%&&&&&&%%%%%%&&&%%&&%%%%%%##,####(####%%%%%%%%%&%%%%#%#%
%##%#%#%%%%%#%%#%(##%&&&&%&&&&%%#&&&&&&&&&&&&&&&%&&&&&%%%%((#(((###%%%%%%&&&&&&&&&&&&&&%%%%%#((#(##################%#%%%
%%#%%%%%%%%%%%%%##%%%&&%%&&&&%%%##%####(####(#######(###(((###(#(#(###%%%&&&&&&&&&&&&&&&&&%%%%#(((/((((((((#(((((((####%";
        string _18 = @"
/////////////////////////////***///*******,,**,*,,,*,,****//*,***,,,,*,,**********************************************//
*/****************************,,,,*************,,,,,***,,,,,,,,,,,,,,,,,,,,,,*******************************************
****************************//*,,*,*************,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********
************************,,,**,,,,************,,,*,,,,,,,,,,,,,*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
%%%%%%%%#********,,,,,,,,,,,,,,,,,,,,,,,,,..,*********,,,,,,,....,,,,,,....,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%,,,,,,,,.........,...,,.....,,,................,,.........,,,,,,...,,,.........,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%&&%%%(........................................................................................,,,,,,
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&*........................................................................................
%%%#%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&%%%,................................................................................
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&%%%%%&%%%/ ..........................................................................
%%%%%%%%%%%%%%%%&&%%%%%&&&&&&&&&&&&&&%&%%%%%%%%%%%##(((((((((((*........................................................
%%%%%&&%%&&&&&&&&&&&&&%&%&&&&&&&&&&&&&&&&&&&&&&&%&&&&&&%(#(#((((((((((((/. .............................................
%%%%%&&&&&&&&&&&&&&&&%%%&&&&&&&%%%%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%#######(((/((////*,..*******,,,,..................
%&&&&%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%&&&&&&%&&&&%%%%%%%%&%%%%%%%%%%%%%%############(((((////////****,,*,**,*********/
%%%%%%%%%%%%%%%%%%%%%&%%%&&&%%#(&&&&&&%%%%%%&&%&%&&&%#%&&&&&&&%(%%##%%%%%%%%%%########(#((((((((/////////////////////(((
%%%%%##%%%%%%%%%%%%%%%&&&&&&%%%**#%&&&&&%&&&&%%%%#(#&&&&&&&&&&&&#,%%%&%%%##(%%%%%##%#######(((((((((((////////((((((((((
%%%%####%%%%%%%%%%%%&&&&&%%%%%%#/(%&&&&&&&&&&%%%##(&&&&&&&&&&&&&%(,*%%%%%%%%%#%%%%%%%%%###############((((((##((((######
%%%%%%%%%%%%%%%%%%%&&&&&&%%%%%%##*(%%%%&&&&&&&&&%/%&&&&&&&&&&&&&&&%/,,*##%%#%%%%%%%%%%%%%%#############################%
%%%%%%%%%%%%%%&&#%&&&&&&&&%%%%&&&&/,%&&&%&&&&&&&%/%&&&&&&&&&&&&&&&%%%%%%%&&%,**%%%%%%%%%%%%%%%%%%%########%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%&&&&&//%%&&&%%%&&&%%/%&%&&&&&&&&&&&&&&&&&&&&&&&%%#%/(%%%%%%%%%%%%%%%%%##%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%&%%&#%%%##%&%&&&%%##%%%%%%%%%((%((#%&&&&&&&&&%%&&&&&&&&&%%%%#(#(,,%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%
&&&&&&&&&&%%%%%%%%%%&%%%%%%%%%%&&%#%%%%%%%%%%%%&%%##%%&&&&&&&&&&%%&&&&&&&&&&&%%%%%%#(,*%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%
#####%%#&&&&&%%%&%%#%%%%%%%%%%%%%#%%*%%%%%%%%#%%#(%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%%###/%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%
#########(#(((((#(###%%%%%%%%%%%%##%#(#(##((((%%%%&&&&&&%%%&&&&&&&&&&&&&&&&&&&&&%%%%%%%%#####%%%%%%%%%%%%%%%%#&&&&&%%%%%
#%##########(#######%%&&&&&&%%%%%%%%%##%#%&&&&&&&&&&%%%%%&&%%%(&%&&&&&&&&&&&&&&&&&&&&&&%%%%%#(###(####%%%%%%%%%%%%#%#%##
%#####%%%#%%####%###%&&&&&&&&&%&#%&&&&&&&&&&&&&&%%&&&&&&&%#(((((#%%%%%%&&&&&&&&&&&&&&&&&&&%%%%#((#######(##########%%%%%
%%%%#%%%#%%%%%%%%#%%%&&&%&&&&%%%####(##########(#####(###((#(#(%#%####%%&&&&&&&&&&&&&&&&&&&&%%%%((/(((((((###((((((#####";
        string _19 = @"
/////////////////////////////*/*///******/*,**,*,*,*,,***///*,***,,,,*,,*********************************************///
*/****************************,*,,*************,,,,,***,,,,,,,,,,,,,,,,,,,,,********************************************
****************************//*,******************,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********
************************,,,**,,,,************,,,*,,,,,,,,,,,,,*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
%%%%%%%%(********,,,,,,,,,,,,,,,,,,,,,,,,..,,*********,,,,,,,...,,,,,,,....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%##,,,,,,,,.........,...,,...,.,,,.,........,.....,,,,.......,,,,,,...,,,,,,,.....,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%&&%%&*..............................................................................................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%*........................................................................................
%%%#%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&%%%,................................................................................
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&%%%%%&%%%*...........................................................................
%%%%%%%%%%%%%%%%&&%%%&&&&&&&&&&&&&&&&%%%%%%%%%%%%%##((((((((((/,........................................................
%%%&&&&%%&&&&&&&&&&&&&%&%&&&&&&&&&&&&&&&&&&&&&&&%&&&&&&%(#((#((#((((((((/. .............................................
%%%%%&&&&&&&&&&&&&&&&%%%&&&&&&&%%%%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%######((((((////*...*******,,,,..................
%&&&&%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%&&&&&&%&&&&%%%%%%%%&%%%%%%%%%%%%%%%%##########(((((((//////****,,,,**,*********/
%%%%%%%%%%%%%%%%%%%%%&%%%%&&%%#/&&&&&&%%%%%%&&%&%&&&%#%&&&&&&&%(%%#%%%%%%%%%%%##########((((((((/////////////////////(((
%%%%%##%%%%%%%%%%%%%%%&&&&&&%%%/*#%&&&&&%&&&&%%%%#(#&&&&&&&&&&&&#,#%%&%%%###%%%%%##%#######(((((((((((////////((((((((((
%%%%#%##%%%%%%%%%%%%&&&&&%%%%%%#/#%&&&&&&&&&&%%%##/%&&&&&&&&&&&&%#./%%%%%%%%%#%%%%%#%%%###############((((((##(((#######
%%%%%%%%%%%%%%%%%%%&&&&&&%%%%%%##*#%%%%&&&&&&&&&%/%&&&&&&&&&&&&&&&%/,,*##%%#%%%%%%%%%%%%%%#############################%
%%%%%%%%%%%%%%&&%%&&&&&&&&%%%%&&&&/*%&&&%&&&&&&&%/%&&&&&&&&&&&&&&&%%%%%%%&&%***%%%%%%%%%%%%%%%%%%%########%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%&&&&&*/%%&&&%%%&&&%%/%&%&&&&&&&&&&&&&&&&&&&&&&&%%#%*(%%%%%%%%%%%%%%%%%##%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%&%%&#%%%##%&%&&&%###%%%%%%%%%((%(##%&&&&&&&&&%&&&&&&&&&&%%%%#(#(,.%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
&%&&&&&&&&%%%%%%%%%%&%%%%%%%%%%&&%#%%%%%%%%%%%%&%%##%%&&&&&&&&&&&&&&&&&&&&&&&%%%%%%#(,/%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%
#####%%#&&&&&%%%&&%#%%%%%%%%%%%%%#%%*%%%%%%%%#%%##%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%%###*%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%
#########(#(#((##(###%%%%%%%%%%%%##%#(((##(((/%%%%&&&&&&&%%&&&&&&&&&&&&&&&&&&&&&%%%%%%%%#####%%%%%%%%%%%%%%%%#&&&&&%%%%%
############(###(###%%&&&&&&%%%%%%%%%%#%#%&&&&&&&&&&%%&&%&&%%%(&%&&&&&&&&&&&&&&&&&&&&&&%%%%%#(###(####%%%%%%%%%%%%#%#%##
%#%###%%%%%%####%###%&&&&&&&&&%&#%&&&&&&&&&&&&&&&&&&&&&&&%((((((#%%%%%%&&&&&&&&&&&&&&&&&&&%%%%#((#######(#########%%%%%%
%%%%#%%%%%%%%%%%%#%%%&&&%&&&&%%%####(######(#########(###((#(####%####%%&&&&&&&&&&&&&&&&&&&&%%%%((((((((((####(((((#####";
        string _2 = @"
******************************///////////////////////(((((((((((((((((##########################################%%%%%%%%
,,,,,,,***************************/////////////////////////////(((((((((((((((((((((((((################################
,,,,,,,,,,,,,,,,*,,,*************************************//////////////////((((((((((((((((((((((((((((#################
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************************///////////////////////(((((((((((((((((((((((((((((((((
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************///////////////////////////////((((((((((((((((((((
...................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************************////////////////////////////////(((((((
..............................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************/////////////////////////////
.....................................,,,,,,,,,,,,,,,(%(,,,,,,,,,,,********************************//////////////////////
#####/,......................................,,,,(&&&&&&&%,,,,,,,,,,,,,,,,,********************************/////////////
###########%##*................................,#&&&&&&&&&&*,,,,,,,,,,,,,,,,,,,,**************************************//
#######%%%%%%%%%%%%%%%%%%%/...................*#%%&&&&&&&%*,,,,,,,,,,,,,,,,,,,,,,,**************************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#(.........../*(&&&&&&&&/...,,,,,,,,,,,,,,,,,,,,,,,,,,**********************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%///%&&&&&&&&&,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************
##%%%%%%%########%%%%%%%%%%&&&%%%%%%%%%%%#(*(%&&&&&&&&&&%%%%%&%(,,,,,,,,,,,,,,,,,,,,*,**********************************
##########%##%%%##############%%%%%%###%%(*/%&&&&&&&&&&&##%%%%&&&&&&&&&&%%&&%%##(//*************************************
###############################%%%%%%&%%%/*/%&&&&&&&&&&&##%%%%%%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%#(/*/**********
#####%%%#%%%%%###########################**#&&&&&&&&&&&&%%%%%%%%%%#####%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&(/
##%%%%%#################################*,/%%&&&&&&&&&&&##(%&&@%%###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%#%##%%%%%%########%#####%%%%%%%%##,*/%&&&&&&&&&&&&&%(/&&&&&&%#######%#################%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%&%%%%%%%%%%%%%%%###%%%%%%/*/#%&&&&&&&&&&&&&&//#&&&&&&&&&%%%%%%##%%%#############%######%%%%%%%%%%%%%%%%%%%%%
##%#####%%%#%%#%%########%##%%%%%%%%((*%&&&&&&&&&&&&&&&&(*##&&&&&&&&&&&&&%%&%%%&%#%%%%%%%%&&&&&&%###########%%%%%%%%%%%%
(((((((((((((((((((((((/((((((((((((/(#&&&&&&&&&&&&&&%&&&&&&%%&&&&&&&&&&%%%%%%%&&%%%%%%%%%&&&%%%%%%%%%%%%##%#%%%%%%%%##%
#######(###%####(######%#####(#(((((((#&&&&&&&&&&&&&&%#&#(##%%%&&&&#((((((##(########((#((((((#(############(#(#########
####(###########################%#%%#(#&&&&&&&&&&&&&&&%##%%##%%%%%%%(###########(####(####%%%############%%%%%%%%%%%%%%%
%%%%%%%%%##########(#(################%&&&&&&&&&&&&&&&%###%%%%%%%%%%%####(#######%%%%%######%##%%%#####################%
&%%%%&&%%%%%%%########%###############%&&&&&&&&&&&&&&&%##%&#%%%%%%%%%#####%%%%%%%%##%%%%%%%#%#%%%####%##%%%#%#####%##%%%
&&&&&&&&&&&&&&%%%%##%%%&&%%%%######(#(&&&&&&&&&&&&&&&&&##(#/%%%%%%%%%%%&%%#%#%%%%%%%%%%%%%%%#%%%%%%%#%###%%%##%%%%%%%%##";
        string _20 = @"
/////////////////////////////*/*///******/*,**,*,*,*,,***///*,***,,,,*,,*********************************************///
*/****************************,*,,*************,,,,,****,,,,,,,,,,,,,,,,,,,,********************************************
*******************************,******************,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********
************************,,**,,,,,************,,,*,,,,,,,,,,,,,,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
%%%%%%%%(********,,,,,,,,,,,,,,,,,,,,,,,...,,*********,,,,,,,...,,,,,,,....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%##,,,,,,,,........,,...,,...,.,,,,,........,.....,,,,.......,,,,,,,,,,,,,,,,.......,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%&&%%&*..............................................................................................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%*..................................................................................,,,,,,
%%%#%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&%%%%.................................................................................
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&%%%%%&%%%............................................................................
%%%%%%%%%%%%%%%%&&%%%&&&&&&&&&&&&&&&&%%%%%%%%%%%%%#(((((((((#(*. .......................................................
%%%&&&&%%&&&&&&&&&&&&&%&%&&&&&&&&&&&&&&&&&&&&&&&%&&&&&%%((((#((#(((((((/*  .............................................
%%%%%&&&&&&&&&&&&&&&&%%%&&&&&&&%%%%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%######(((*///(/*....,******,,,,..................
%&&&&%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%&&&&&&%&&&&%%%%%%&%%%%%%%%%%%%%%%%%%%#########(((((((/////*****,,,,**,*********/
%%%%%%%%%%%%%%%%%%%%%&%&%%&&&%%(#&&&&&%%%%%%&&%&%&&&&%%%&&&&&&&&%#%#%%%%%%%%%###########((((((((/////////////////////(((
%%%%%##%%%%%%%%%%%%%%%%&&&&&&%%#*/%&&&&&%&&&&%%%%###(#&&&&&&&&&&&%/(/%%%%###%%%%%##%####(##(((((((((((//////(/((((((((((
%%%%#%##%%%%%%%%%%%%%&&&&&%%%%%%#*#%&&&&&&&&&%%%###(#%&&&&&&&&&&&&#(*//#%%%%%#%%%%%#%%%###############((((((##(((#######
%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%#(*#%%%&&&&&&&&&%%###%&&&&&&&&&&&&&%#(/**//#%%%%%%%%%%%%%%#############################%
%%%%%%%%%%%%%%&&%%%&&&%&&&&%%%%&&&(*#&&&%&&&&&&&&&%%#%&&&&&&&&&&&&&&&%%%%%%%%#***/#%%%%%%%%%%%%%%%########%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%&%&&&%%%&%%%%%%&&&&/*%%&&&%%%&&&&&%(##%%%&&&&&&&&&&&&&&&&&&&&&&%%%%*#/%%%%%%%%%%%%%%##%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%##%%%&&%/##%%%%%%%%%%%#%///#%&&&&&&&%&&&&&&&&&&%%%%%%%##**//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
&%&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%&&#%##%%%%%%%%%&&&%%%%&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%%#/*//%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%
#####&%#&%&&&%&%&%%%%%%%%%%%%%%%%%%(%%%%%%%%%#%%%%(%%%&&&&&&&&&&&&&&&&&&&&&&&&&&%&%%%%%%###/%#%%%%%%%%%%%%%%%%&%%%%%%%%%
###########(#((##(###%%%%%%%%%%%%%%#((#####(/%%%%%&&&&&&&%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%##/%(%%%%%%%%%%%%%%&&&&&%%%%%
###################(%&&&&&&&&&%%%%%%%%%%%%&&&&&&&&&&&&&&&&&%%((((##&&&&&&&&&&&&&&&&&&&&&&&%%%%#/#####%%%%%%%%%%%%%#%#%%#
%%%##%%%%%%%####%##%&&&&&&&&&&%%%%%%&&&%&%%%%%%############(((((#%%%#%####&&&&&&&&&&&&&&&&&&%%%%(#(#####(##########%%%%%
%%%%%%%%%%%#%%%%%#%%%&&&&&&&%&%%%##########((####(####((#(((((##%%####%#%%%&&&&&&&&&&&&&&&&&&&%%%##(((((((######((######";
        string _21 = @"
////////////////////////////////////*****/*,**,*,*,******///*,****,,,*,,*********************************************///
*/****************************,*,,************,,*,,*//**,,,,,*,,,,,,,,,,,,,,********************************************
*******************************,******************,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********
************************,,**,,,,,***********,.,,,,,,,,,,,,,,,,,*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
%%%%%%%%(********,,,,,,,,,,,,,,,,,,,,,,,...,,*********,,,,,,,..,,,,,,,,....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%#/,,,,,,,,,.......,,...,,..,,.,,,,,...,,...,.....,,,,.......,,,,,,,................,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%&%%%%,..........,...................................................................................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&#*........................................................................................
%%%#%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&%%#.................................................................................
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&%%%%%&%%%............................................................................
%%%%%%%%%%%%%%%%&&%%%&&&&&&&&&&&&&&&&%%%%%%%%%%%%%#(((((((((#(.. .......................................................
%%%%%&&%%&&&&&&&&&&&&&%&%&&&&&&&&&&&&&&&&&&&&&&&%&&&&&%%((((#((#(((((((/................................................
%%%%%&&&&&&&&&&&&&&&&%%%&&&&&&&%%%%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%######((/,*///*,.....******,,,,..................
%&&&&%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%&&&&&&%&&&&%%%%%%&%%%%%#%%%%%%%%%%%%%#########(((((((/////*****,,,,*,,**********
%%%%%%%%%%%%%%%%%%%%%&%&&%%&&&%%(&&&&&%%%%&%%&%&%%&&&&%%%&&&&&&&&&%(#%%%%%%%%########(##((((((((////////***//////////(((
%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%%/,#%&&&&&&&&&%%&%%%##/#&&&&&&&&&&&&%,#######%%%%%##%####(#((((((((((((///////(((((((((((
%%%%#%%#%%%%%%%%%%%%%%&&&&%%%%%%%(*#&&&&&&&&%%%%#####(&&&&&&&&&&&&&&#*.##%%%%#%%%%%#%%%###############(((((((#(((#######
%%%%%%%%%%%%%%%%%%%%&&&&&&%%%%%%%#*#%%%&&&&&&&&%%%%%/%&&&&&&&&&&&&&&%%%#,.,/%%#%%%%%%%%%%%#############################%
%%%%%%%%%%%%%%&&%&%&&&%&&&&&%%%&&&&**&&&%&%&&&&&&&&&((%&&&&&&&&&&&&&&&&&%%%%%%%(,,/%%%%%%%%%%%%%%%########%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%&&%&&%%#&%%%%%%&&&&#*&%&&&%%%&&&&&&%((%%%%&&&&&&&&&&&&&&&&&%%&&%%%%%%,#%%%%%%%%%%%%%##%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%&%%%%%%%%##%%&&&*##%&%%%%%%%%%&&*((/%%&&&&&&%&&&&&&&&&&%%%%%%%%##,,,%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
&&&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%&&#(((%%%%%%%%%&&&%%%%%&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%%#/,%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%
%####&%#&%&&&&&%&%&%%%#%%%%%%%%%%%%/%%%%%%%%%#%%%#%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%####(%%%%%%%%%%%%%%%%&%%%%%%%%%
###########(##(######%%%%%%%%%%%%%%%#((###((/%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%###*%%%%%%%%%%%%%%&&&&&%%%%%
###################(%%&&&&&&&&%%%%%%%%%%&&&&&&&&&&&&&%%%%%%%%(((/(#&&&&&&&&&&&&&&&&&&&&&&&&%%%%%#####%%%%%%%%%%%%%%%#%%#
%%%#%%%%%%%%%%#(##(%%&&&&&&&&&%##%%%&&&&%%#####(((##(######((((##%#%#%##((&&&&&&&&&&&&&&&&&&&%%%%#*###############%%%%%%
%%%%%%%%%%%#%%%%%%%%%&&&&&&&%&&%%#(%#############(#####(##(((((#%%(###%####&&&&&&&&&&&&&&&&&&&&&%%%/((((((#####((#######";
        string _22 = @"
////////////////////////////////////****//*,******,,****/////,****,,**,*********************************************////
/**////************//************,************,,*,,*//**,,,****,,,,,,,,,,,**********************************************
**************************//***,********************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******************
****************************,,,,,************,*,,,,,,,,,,,,,,,******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
%%%%%%%%/******************,*,**,,,,,,,,.,,,***********,,,,,,..,,,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%#/,,,,,,,,,,.,.,,.,,..,,,..,,.,**,,,..,,...,...,,,,,,,.....,,,,,,,,.......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%&......,,..,,...,..,,,,,...,,,..............................................,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&#*........................................................................................
%%%#%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&%%(.................................................................................
%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&%%%%&%%%............................................................................
%%%%%%%%%%%%%%%%&&%%%&&&&&&&&&&&&&&&&&&%%%%%%%%%%%#####(((((#/..........................................................
%%%%%&&%%&&&&&&&&&&&&&%&&&&&&&&&&&&&&&&&&&&&&&&&%&&&&&%%#(#(#((#(((((((*................................................
%%%&&&&&&&&&&&&&&&&&&%%%&&&&&&&%%%%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%######((*.,*//*......,*****,,,,..................
%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%&&&&&%&&&&%%%%%%&%%##((###%%%%%%%%%%##########((((((/////*****,,,,*,,********,,
%%%%%%%%%%%%%%%%%%%%&&&&&&%&&&&%%(&&&&&%%%&%%&%&%%&&&&&%#%&&&&&&&&&&&(%%%%%%%%%%######((((((((((///////****//////////(((
%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&%*,%&&&&&&&&&%&&%%%###/(&&&&&&&&&&&&%%,(####%%%%%##%%%####(((((((((((((//////(((((((((((
%%%%%%%#%%%%%%%%%%%%%%%&&&&%%%%%%(*(&&%&&&&&%%%%######/%&&&&&&&&&&&&&%#*,((%#%%%%%%%%%%##%%###########(((((((#(((#######
%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%%%%##,#%&&&&&&&&&%%%%%%#(&&&&&&&&&&&&&&&%%%#*.**(/(#%%%%%%%%%%###########################%
%%%%%%%%%%%%%%&&%%&%&&&%&&&&%%%%&&%/*%&&&&&&&&&&&&&&&%%%&&&&&&&&&&&&&&&&&&&&&&&&%(,*,(%%%%%%%%%%%%#######%%%%%%%%%%%%%%%
%%%%%%%%%%%%&&%%&&&%&&%%%&#%%%%%&&&&/&&&&&%%%&&&&&&%%#/%%%%%&&&&&&&&&&&&&&&&&%%%%%%%%##,%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%&&%%%&&&%%%%%%%%##%&&&((#%&&&&&%%%%%&&&&/#(%%&&&&&&&&&&&&&&&&&&&%%%%%%%%/*,#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%&&((#%%%%%%%%&&&&%%%%%%%&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%%#(*#%%%%%%%%%%%%%%%%%%%%%%%%%%%
%####%&%&%&&&&&%&%%%%%&#%%%%%%%%%%%(%%%%#%%%%#%%%%##%%&&&&&&&&&&&&&&&&&&&&&&&&&&&%&&%%%%%%%####(%%%%%%%%%%%%%%&%%%&%%%%%
###########(##(######%&%%%%%%%%%%%%%%%((#%##(%%&&&&&&&&&&&&&&&&&&##&&&&&&&&&&&&&&&&&&&&&&&%%%%%##/%%%%%%%%%&%&&&&&&%%%%%
####################%%&&&&&&&%%%&%%%%%&&&&&&&&&&&&&&&&&&&%%%%((((((((%&&&&&&&&&&&&&&&&&&&&&&&%%%%#(#%%%%%%%%%%%%%%%%#%%%
%%%#%#%%%%%%%%%##%#%%&&&&&&&&&%/##%%%%&&#%%######(##(###(##(#((##%%%%%##((((&&&&&&&&&&&&&&&&&&&%%%%##############%%%%%%%
%%%#%%%%%%%%%%%%%%%%&&&&&&&&&%%%###%######%##########(%(##((#((#%#/%###%##%%#&&&&&&&&&&&&&&&&&&&%%%%%(((((##############";
        string _23 = @"
////////////////////////////////////****//********,,**/*/////,****,,**,*********************************************////
///////************//*************************,,*,,*//**,,,****,,,,,,,,,,,**********************************************
***//*********************//***,********************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******************
****************************,,,,,************,*,,,,,,,,,,,,,,,******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
%%%%%%%%(******************,*,**,,,,,,,,.,,,***********,,,,,,..,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%#(,,,,,,,,,,.,.,,.,,..,,,..,,.,**,,,..,,..,,...,,,,,,......,,,,,,,,....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%&&&%&,.....,,..,,...,..,,,,,...,,,........,,.,..................................,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&#,........................................................................................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&%%%.................................................................................
%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&%%%%&%%%............................................................................
%%%%%%%%%%%%%%%%&&%%%&&&&&&&&&&&&&&&&&&%%%%&&%%%%%#####(((((#*..........................................................
%%%%%&&%%&&&&&&&&&&&&&%&&&&&&&&&&&&&&&&&&&&&&&&&%&&&&&%####(#((((((((((*................................................
%%%&&&&&&&&&&&&&&&&&&%%%&&&&&&&%%%%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%######(/*.,***,......,****,,,,,..................
%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%&%%&&&&&&%&&&&%%%%%%&%%%(#&&&&%#%%#%%%%###########((((((////******,,,,,,,*******,..
%%%%%%%%%%%%%%%%%%%%&&&&&&%%&&&&%%/%&&&%%%&%%&%&%&&&&&&&%%%&&&&&&&&&&&%(#(%%%%%%########((((((((///////****///////////((
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&%**%&&&%&&&&%&&%%%##%%%(#%&&&&&&&&&&&&%*(/(#%%%%##%%%####(((((((((((((//////(((((((((((
%%%%%%%#%%%%%%%%%%%%%%&&&&&&%%%%%%(*#&&&&&&&%%%%######&%##&&&&&&&&&&&&&&%(,**/(##%%%%%%##%%###########(((((((((((#######
%%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%%%%(((%&&&&&&&&&%%%%%%%&*%#&&&&&&&&&&&&&&&%%%(,***//((##%%%%%###########################%
%%%%%%%%%%%%%%&&%%%%#%&&&%&&&%%%%%#%*#&&&&%&&&&&&&&&&&&%#(#%%&&&&&&&&&&&&&&&&&&&&&%%****/#%%%%%%%%#######%%%%%%%%%%%%%%%
%%%%%%%%%%%%&%%%&&&&&&%%%%%%%#%%&&%%(#&&&&%%%&&&&&%%%%%###%##%&&&&&&&&&&&&&&&%%%%%%%%%%##*#(%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%&&%%%&&&&%%%%%%%###%&&/#%&&%&%%%%%%%&&&&&%(%#%&&&&&&&&&&&&&&&&&&&&%%%%%%%%#(*#/#%%%%%%%%%%%%%%%%%%%%%%%%%%
&&&&&&&&&&&&&&&&&%%%%%%#%%%%%%%%%&&(#%%%%%%%%%&&&&%%%%%(#%&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%%%%##/#/%%%%%%%%%%%%%%%%%%%%%%%
#####%%#%%&&&&&%&%%(%%&##%%%%%%%%%%*%%%%#%%%%%%%%##&&%&&&&&&&&&&&&&&&&&&&&&&&&&&&%&&%%%%%%%%%%###(%(%%%%%%%%%%&%%%&%%%%%
##%#########((((#(##%%%%%%%&%%%%%%%%%%%&%#%##%&&&&&&&&&&&&&&&&&%%((((%%&&&&&&&&&&&&&&&&&&&%&&%%%%%####%%%%%&%&&&&&&%%%%%
###################%%%&&&&&&&%%#(#%%%%%&&&&&&&&&%%&%%######((((((/((((((###%%%&&&&&&&&&&&&&&&&&%%%%%/%(%%&%%%%%%%%%%%%%%
%%%%%%%%%#%%#%##%%%%%&&&&&&&&&%###%%%%%%%%#####(#(#########(##(#%%#%%%%#(((((##%&&&&&&&&&&&&&&&&%%%%%%%###########%%%%%%
%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%(#%#%#############(####((##(/#((#%#(%#(#%(##%#%#%%&&&&&&&&&&&&&&&%%&&&%%#((##############";
        string _24 = @"
////////////////////////////////////****//********,,**/*/////,****,,**,*********************************************////
///////*********/////*************************,,*,,*//**,,,****,,,,,,,,,,,**********************************************
***//*********************//***,********************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******************
****************************,,,,,************,*,,,,,,,,,,,,,,,******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
%%%%%%%%(******************,*,**,,,,,,,,.,,,***********,,,,,,..,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%#(,,,,,,,,,,.,.,,.,,..,,,..,,.,**,,,..,,..,,...,,,,,,......,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%&&&%&,.....,,..,,...,..,,,,,...,,,........,,....................................,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&#,........................................................................................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&%%%.................................................................................
%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&%%%%&%%%............................................................................
%%%%%%%%%%%%%%%%&&%%%&&&&&&&&&&&&&&&&&&%%%%&&%%%%%#####(((((#*..........................................................
%%%%%&&%%&&&&&&&&&&&&&%&&&&&&&&&&&&&&&&&&&&&&&&&%&&&&&%####(#((((((((((*................................................
%%%&&&&&&&&&&&&&&&&&&%%%&&&&&&&%%%%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%######(/*.,***,......,****,,,,,..................
%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%&%%&&&&&&%&&&&%%%%%%&%%%(#&&&&%#%%#%%%%###########((((((////******,,,,,,,*******,..
%%%%%%%%%%%%%%%%%%%%&&&&&&%%&&&&%%/%&&&%%%&%%&%&%&&&&&&&%%%&&&&&&&&&&&%(#(%%%%%%########((((((((///////****///////////((
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&%**%&&&%&&&&%&&%%%##%%%(#%&&&&&&&&&&&&%*(*(#%%%%##%%%####(((((((((((((//////(((((((((((
%%%%%%%#%%%%%%%%%%%%%%&&&&&&%%%%%%(*#&&&&&&&%%%%######&###&&&&&&&&&&&&&&%(,**/(##%%%%%%##%%###########(((((((((((#######
%%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%%%%((/%&&&&&&&&&%%%%%%%&/%#&&&&&&&&&&&&&&&%%%(,***//((##%%%%%###########################%
%%%%%%%%%%%%%%&&%%%%#%&&&%&&&%%%%%#%*#&&&&%&&&&&&&&&&&&%#(#%%&&&&&&&&&&&&&&&&&&&&&%%****/#%%%%%%%%#######%%%%%%%%%%%%%%%
%%%%%%%%%%%%&%%%&&&&&&%%%%%%%#%%&&%%(#&&&&%%%&&&&&%%%%%###%##%&&&&&&&&&&&&&&&%%%%%%%%%%##*#(%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%&&%%%&&&&%%%%%%%###%&&/#%&&%&%%%%%%%&&&&&%(%#%&&&&&&&&&&&&&&&&&&&&%%%%%%%%#(*#/#%%%%%%%%%%%%%%%%%%%%%%%%%%
&&&&&&&&&&&&&&&&&%%%%%%#%%%%%%%%%&&(#%%%%%%%%%&&&&%%%%%(#%&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%%%%##/#/%%%%%%%%%%%%%%%%%%%%%%%
#####%%#%%&&&&&%&%%(%%&##%%%%%%%%%%*%%%%#%%%%%%%%##&&%&&&&&&&&&&&&&&&&&&&&&&&&&&&%&&&%%%%%%%%%###(%(%%%%%%%%%%&%%%&%%%%%
##%#########((((#(##%%%%%%%&%%%%%%%%%%%&%#%##%&&&&&&&&&&&&&&&&&%%((((%%&&&&&&&&&&&&&&&&&&&%&&%%%%%####%%%%%&%&&&&&&%%%%%
###################%%%&&&&&&&%%#(#%%%%%&&&&&&&&&%%&%%######((((((/((((((###%%%&&&&&&&&&&&&&&&&&%%%%%/%(%%&%%%%%%%%%%%%%%
%%%%%%%%%#%%#%##%%%%%&&&&&&&&&%###%%%%%%%%#####(((#########(##(#%%#%%%%#(((((##%&&&&&&&&&&&&&&&&%%%%%%%###########%%%%%%
%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%(#%#%#############(####((##(/#((#%%(%#(#%(####%#%%&&&&&&&&&&&&&&&%%&&&%%#((##############";
        string _25 = @"
////////////////////////////////////****//******,*,,**/*////*,****,,**,*********************************************////
///////*********/////************,************,,*,,*//*,,,,****,,,,,,,,,,,**********************************************
***//**********************/*/*,********************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******************
/************************,***,,,*************,*,*,,,,,,,,,,,,,******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
%%%%%%%%%*********,**********,**,,,,,,,,,,,,,**********,,,,,,..,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%,,,,,,,,,.......,,..,,,..,,.,,,,,....,..,,...,,,,,,......,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%&&&%&/.....,,..,,...,..,,,,,...,,,........,,..,,..................................,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&.........................................................................................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&%%&.................................................................................
%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&%%%%&%%%............................................................................
%%%%%%%%%%%%%%%%&&%%%&&&&&&&&&&&&&&&&&&%%%%&&%%%%%#####(((((#/..........................................................
%%%%%%%&&&&&&&&&&&&&&&%&&&&&&&&&&&&&&&&&&&&&&&&&%&&&&&%###((#((((((((((*................................................
%%%&&&&&&&&&&&&&&&&&&%%%&&&&&&&%%%%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%#####((/*.,***,......,****,,,,...................
%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%&%%&&&&&&%&&&&%%%%%%&%%&#%&&&&&&&%%%#%%%##########((((((////******,,,,,,,*******...
%%%%%%%%%%%%%%%%%%%%&&&&&&&%&&&&&%((&&%%%%%%%&%%%&&&&&&&&&##%&&&&&&&&&&&#/#(%%%#########((((((((///////****//*///////(((
%%%%%%#%%%%%%%%%%%%%%%%%%%&&&&&&&&#,(%&&&&&&&%&%%%%##%%&&(%#&&&&&&&&&&&&&%*//(#%###%%%####((((((((((((////////((((((((((
%%%%%%%%%%%%%%%%%%%%%%&&%&&&%%%%%%%//%&&&&&&%%%%######&&&(#%&&&&&&&&&&&&&&%#**///###%#%##%%##########((((((((((((#######
%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%#*#&&&&&&&&&%%%%%%&&&&#%#&&&&&&&&&&&&&&&%%#(/(##//(//#%%%###########################%
%%%%%%%%%%%%%%%&&%%%%%%&&%%&&&%%%&#((#&&&&&&&&&&&&&&&&&&(#((#%%&&&&&&&&&&&&&&&&&&&&&%%(/*/((#%%%%%#######%%%%%%%%%%%%%%%
%%%%%%%%%%%%&%%%&&&&&&%%%%%%%%#%%&%(%#&&&&%%%&&&&&%%%%%%%(#(((#%&&&&&&&&&&&&&&&%%%%%%%%%%#/*(((%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%&&%%%&&%&#%%%%%%%##%&&/#%&&%%%%%%%%%&&%&&&&%#%%&&&&&&&&&&&&&&&&&&&%%%%%%%%%%%#*#%/#%%%%%%%%%%%%%%%%%%%%%%%
&%&&&&&&&&&&&&&&&%%%%%%##%%%%%%%%&&###%%%%%%%&&&&&%%%%%%#%%&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%##*##/%%%%%%%%%%%%%%%%%%%%
########%%%&&&%&&%%#%%&###%%%%#%%%%/%%%%#%%%%%%%%#(%%%&&&&&&&&&&&&&&&&%&&&&&&&&&&&&&&&&%%%%%%%%%%##*##%%%%%%%%&&&&&%%%%%
##############((#(##%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&%#((((###%%&&&&&&&&&&&&&&&&&&&&&%%%%%%(%(%%%%%&&&&&&%%%%%
#%##############%##%%%&&&&&&&%%(((#%%%%%%&&&&&&%%###(((((((/(((((/((((((##(###%%%%&&&&&&&&&&&&&&&%%%%%(%#%%%%&%%%%%%#%%%
%%%%%%%%%#%%%#####%%%&&&&&&&&&%(##%%%%%%%###%(#(((##############%%%%%%##(((((#((#&&&&&&&&&&&&&&&&%&&&%%%%#########%%%%%%
%%%%%%%%#%%%%%%%%%%%&&&&&&&%%%%#%%%%#(#(#########(#(##(((%/((#(#%%(##(##########(%%&&&&&&&&&&&&&%%&&&&&%########((######";
        string _26 = @"
////////////////////////////////////****//********,***/*////*,***,,,************************************************////
///////*********//////********,**,************,,*,,*//*,,,,***,,,,,,,,,,,,**********************************************
*/*//***********************//*,*******************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******************
(************************,***,,,*************,,***,,,,,,,,,,,,******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****
%%%%%%%%%********,,******,*,*,**,,,,,,,,,,,,,**********,,,*,.,.,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%*,,,,,,,,.......,,...,,..,..,,,,,....,..,,...,,,,,,......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%&&&&&(..,..,,..,,....,.,,,,,...,,,.......,,,.,,,................................,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&.........................................................................................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&%%%.................................................................................
%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&%%%&&%%%,...........................................................................
%%%%%%%%%%%%%%%%&&%%%&&&&&&&&&&&&&&&&&&&%&&&&%%%%%###(((((((#/..........................................................
%%%%%%%&&&&&&&&&&&&&&&%&&&&&&&&&&&&&&&&&&&&&&&&&%&&&&&%###((#(##(((((((*................................................
%%%&&&&&&&&&&&&&&&&&&%%%&&&&&&&%%%%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%####%%####((/,.,/**,......*****,,,,...................
%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%&&&&&&%&%&&%%%%%%%&&&%#&&&&&&&&&&/%%%##########(((((/////******,,,,,,,******,...
%%%%%%%%%%%%%%%%%%%%&&&&&&%%%&&&&%#/%&%%%%%&%&%%%&&&&&&&&&&(#&&&&&&&&&&&&%/*#%%#########((((((((///////****//*////////((
%%%%%%#%%%%%%%%%%%%%%%%%&%%&&&&&&&%/*%&%&&&&&%&%#####%%&&&%/&&&&&&&&&&&&&&%(,*#####%%%####((((((((((((////////((((((((((
%%%%%%%%%%%%%%%%%%%%%%&&%%&&&%%%%%%(*#&&&&&&%%%%######&&&&((&&&&&&&&&&&&%&&&%#/,,(#%%#%%%%%##########((((((((((((#######
%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%#*#&&&&&&&&&%%%%&%&&&&&#*%&&&&&&&&&&&&&&&%%%%%%%%%%,,(##%###########################%
%%%%%%%%%%%%%%%&&%%%%%%&&%#&&&%%%&&*(#&&&&&&&&&&&&&&&&&&&&#/(&%%&&&&&&&&&&&&&&&&&&&&&%%%%***#%%%%########%%%%%%%%%%%%%%%
%%%%%%%%%%%%&%%%&&&&&&%%%%%%#%#%%&%/%%&&&&%%%&&&&&%%%%%&&&/(#//%&&&&&&&&&&&&&&&%%%%%%%%%%%##***%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%&&%%%&&%&#%%%%#%%###&&*%&&&%%%%%%%%%&&%&&&%%%%%%&&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%#.(%%%%%%%%%%%%%%%%%%%%%%%
&&&&&&&&&&&&&&&&&&%%%%&###%%%#%%%%&%##%%%%%%%&&&&%%%%%%%%#%&&&&&&&&&&&&&&&&&&&&&%%&&%%%%%%%%%%%%##(*%%%%%%%%%%%%%%%%%%%%
######%#%%%&&%&&&%##%%%###%%%%%%%#%(%%%%#%%%#%%%%%(%%&&&&&&&&&&&&&&&&&%&&&&&&&&&&&&&&&&%%%%%%%%%%%%##/%%%%%%%%&&&&&%%%%%
##############(#####%%%%%%%%&%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&#((((##((%&&&&&&&&&&&&&&&&&&&&&&%%%%%##*%%%%%&&&&&%%%%%%
#%##############%#%%%%&&&&&&&%%#(((#%%%%%&&&&&&%%(((((((((((((#(((((((((##(######%&&&&&&&&&&&&&&&%%&&%%%(%%%%%&%%%%%#%%%
%%%%%%#%%%%#%#####%%%&&&&&&&&&&%##%%%%%%%###%##(((#########(####%%%%%%##(((((((((&&&&&&&&&&&&&&&&%&&&&&&%#######%#%%%%%%
%%%%%%%%##%%%%%%%%%&&&&&&&&%%%##%%%##(#(##(######(#((#(((#(((#(#%%###((##%###%###(%&&&&&&&&&&&&&&&&&&&&&&%(###(#((######";
        string _27 = @"
////////////////////////////////////****//,******,,*****////*,***,,,*,**********************************************////
///////*********///////**********,************,,*,,*/**,,,,,**,,,,,,,,,,,,**********************************************
*/*//**********************///*,*******************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******************
(************************,,**,,,*********//**,,**,,,,,,,,,,,,,******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****
%%%%%%%%%********,,******,*,*,**,,,,,,,,,,,,***********,,*,,.,.,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%/,,,,,,,,.......,,.,,,,..,..,,,,,...,,..,,...,,,,,,......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%&&&&&&/*.,..,,..,,....,,,,,,,..,,,,.......,,,.,,,.....,,.....................,,..,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&..............................................................................,,,,,,,....
%%%%#%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&%%#.................................................................................
%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&%%%&&%%&,...........................................................................
%%%%%%%%%%&&%%%&&&%%%&&&&&&&&&&&&&&&&&&&%&&&&%%%%%#####(((((#/..........................................................
%%%%%&&&&&&&&&&&&&&&&&%&&&&&&&&&&&&&&&&&&&&&&&&&%&&&&&&#########(((((((*................................................
&%%&&&&&&&&&&&&&&&&&&%%%&&&&&&&%%%%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%#(((/##(###((/,,*//*,......*****,,,,...................
%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%&%&&&&%%&&&&&%&&&&&%%%%%%%&&%%#%&&&&&&&&&&&*##########((((((/////*****,,,,,,,*******,...
%%%%%%%%%%%%%%%%%%%%&%%&&&%%&&&&&&&(%&%%&%%&&&%%%&&&&&&&&&&&#/&&&&&&&&&&&&%#(*##########((((((((//////*****//*///////(((
%%%%%%%%%%%%%%%%%%%%%%%%&%%&&&&&&&%%*#%%&&&&%%&%#####%&&&&&&/#&&&&&&&&&&&&&%#(,*(###%%####((((((((((((////////((((((((((
%%%%%%%%%%%%%%%%%%%%%%%&&%&&&%%%&%%%//&&&&&&%%%%######&&&&&&/%&&&&&&&&&&%&&&%%%#(,,*/(/((%%##########(((((((((((########
%%%%%%%%%%%%%%%%%%%%%%&%&&&&&%%%%%%#*%&&&&&&&&&%%%%&%&&&&&&&((%&&&&&&&&&&&&&&&&%%%%%%%%##,,/(#########################%%
%%%%%%%%%%%%%%&&&%%%%%%&&%##&&&%%&&#/#&&&&&&&&&&&&&&&&&&&&&&(/%&%%&&&&&&&&&&&&&&&&%%%%%%%%####*%%#######%%%%%%%%%%%%%%%%
%%%%%%%%%%%%&&%&&&&&&%%%%%%%&#%%%&%#(&&&&&%&&&&&&&%%%%&&&&&&*#,*%&&&&&&&&&&&&&&%&&%%%%%%%%%%%#**(%%%#%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%&&&&%&&&&%&#%%%%%#%%##&%/%&&&%%%%%%%%&&&%&&&%%%%%%%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%#%(,(%%%%%%%%%%%%%%%%%%%%
&&&&&&&&&&&&&%&&&&%%%%&####%%%#%%%#(##%%%%%%%&&&%&%%%%%%%(%&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%#((#%%%%%%%%%%%%%%%%%
###(###%%&%&&%&%&&#%%%%####%%%%%%%%%%%%#(#####%%%%%%&%&&&&&&&&&&&&&&&&#%%%&&&&&&&&&&&&&%%%%%%%%%%%%%%%##(%%%%%&&&&&%%&&&
#%%########%##(####%%%%%%%&&%%%*##%%%%(#%%%%&&&&&&&&&&&&&&&&&&&&#((((##((###%&&&&&&&&&&&&&&&&&&&&%%%%%%%#*%%%&&&&&%%%%%%
#####%###########%%%%&&&&&&&&%%#(##(##%%%%%&&&%%%%#(((#((((((/#(((((((((##(######(##&&&&&&&&&&&&&%&&&&&%%%#%%&%%%%%%%%%%
%%%%%%##%%%#%####%%%&&&&&&&&%%#%##%%%%%%%%#%#(%#(##########(####%%%%%%#%((((##(#(((#%&&&&&&&&&&&%%&&&&&&&&%#####%%%%%%%&
%%%%%%%%%#%%%%%%%%&&&&&&&&&&&(##%%##%###########%(#(((#((#(((#((%####((##%####(##(&#/%&&&&&&&&&&%&&&&&&&&&&%(##(########";
        string _28 = @"
////////////////////////////////////****/*,,*,***,******////*****,,,************************************************////
///////*********///////*********,,*************,*,,*/**,,,,,**,,,,,,,,,,,,**********************************************
*/*//**********************////,,,*****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******************
#*************************,**,,,*************,,**,,,,,,,,,,,,,*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
%%%%%%%%%(********,*****,,*,,,**,,,,,,,,,,,,,**********,,,,,.,.,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%&(*,,,,,,,.......,,.,,,,..,..,,,,,.......,,...,,,,,,......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%&&&&&&(*.,.,,,........,,,,,,,..,,.........,.,,,,,.....,,....................,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&,.......,.....................................................................,,.........
%%%%%%%%%%%%%%%&%%&&&&&&&&&&&&&&&&&&%%%.................................................................................
%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&%%%&&%%&,...........................................................................
%%%%%%%%%%%%%%%&&&%%%&&&&&&&&&&&&&&&&&&&&&&&&%%%%%#####(((((#(..........................................................
%%%%%&&&&&&&&&&&&&&&&&%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&#########(((((((*................................................
&%&&&&&&&&&&&&&&&&&&&%%&&&&&&&&%%%%&&&&&&&&&&&&&&&&&%%%&%%%%%%%%%#(%&&&&&&&((((**///*,.....,****,,,,....................
%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&%#/##%&&%%&&&&&%%&&&&%%%%%%%&%%%%#&&&&&&&&&&&%%*(#######((((((////******,,,,,,,*******....
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&/%%%&%%&&&&%&&&&&&&&&&&&&%*%&&&&&&&&&&&&%#(,((#####((((((((///////****///////////(//
%%%%%%%%%%%%%%%%%%%%%%%&&%%&&&&&&%%%#,%%&&&&%%&%#####%&&&&&&%%(&&&&&&&&&&&&&%%##(,,/(##(((((((((((((((///////(((((((((((
%%%%%%%%%%%%%%%%%%%%%%%&&%&&&&%%%%%%#/&&&&&&%%%%#####%&&&&&&%&#&&&&&&&&&&&&&&%%%%##///(#(**(#########(((((((((((########
%%%%%%%%%%%%%%%%%%%%%%&%&&&&&&%%%%%%/(%&&&&&&&&%%%%&%&&&&&&&&%%%%&&&&&&&&&&&&&&&%%%%%%%%%##(*,,#######################%%
%%%%&%%%%%%%%%&&&%%%%%%&&%#%#&%%&&%%/#&&&&&&&&&&&&&&&&&&&&&&&%/%%##(%&&&&&&&&&&&%&%%%%%%%%%%%##(/(######%%%%%%%%%%%%%%%%
%%%%%%%%&%%%&&%&&&&&&%%%%%%%%&%(%%%##(&&&&&&&&&&&&%%%%&&&&&&&&%(%#&&&&&&&&&&&&&%&&%%%%%%%%%%%%%##(,%#%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%&&&%&&&&%%#%%%%%%%##(#(/%%&&%%%%%%%%&&%&&&&%%%%%%(%&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%##(*#%%%%%%%%%%%%%%%%%
&&&&&&&&%&&%%%%%&&&%%%%#####%%%%/%%/%(%%%%%%%&&&%%%%%%%%%#%%&&&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%#(*%%%%%%%%%%%%%&&
####(##%%%&&&&&&%%%%%%%####%%%%%%%%%%%%%%%%%%(%%%%%%#&&&&&&&&&&&&&&&&&#&%%%&%&&&&&&&&&&%%%%%%%%%%%%%%%%%##*%%&&&&&%%%&&&
#%#################%%%%%&&&%%%%(###%%%%#((%%&&&&&&&&&&&&&&&&&&&%(#(((######(#####%%&&&&&&&&&&&&&%%%%&&%%%%%(%&&&&&%%%%%%
%####%###%#%###%##%%%&&&&&&&&%&#(######%%%%%%&&#%%%#(((((((#(/((((((((((#(###########&&&&&&&&&&&%%&&&&&&&%%%##%%%%%%%%%%
%%%%%%%#%%%%%####%%&&&&&&&&&#%/%###%%#%%#%%%#((#############(%###%%%%#%##(#(##((((((###&&&&&&&&&%&&&&&&&&&&&%####%%%%%&&
%%&&%%%%%%%%%%%%#%&&&&&&&&&&/(%##%%#%#########(#%##(#((((#((/(((###(#/((####(#((((((&%#%&&&&&&&%%&&&&&&&&&&&&%#(########";
        string _29 = @"
////////////////////////////////////****/*,**,***,******////*****,,,************************************************////
///////*********///////*********,,************,,*,,,/**,,,,,**,,,,,,,,,,,,**********************************************
*/*//**********************////,,,*****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******************
(*************************,**,,,*************,,**,,,,,,,,,,,,,*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
%%%%%%%%%(********,*****,,*,,,**,,,,,,,,,,,,,**********,,,,,.,.,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%#*,,,,,,,.......,,.,,,,..,..,,,,,.......,,...,,,,,,......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%&&&&&&#*.,.,,,........,,,,,,,..,,.........,.,.,,,.....,,....................,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&,.......,................................................................................
%%%%%%%%%%%%%%%&%%&&&&&&&&&&&&&&&&&&%%%.................................................................................
%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&%%%&&%%%............................................................................
%%%%%%%%%%%%%%%&&&%%%&&&&&&&&&&&&&&&&&&&&&&&&%%%%%#####(((((#(..........................................................
%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&#########(((((((*................................................
&%&&&&&&&&&&&&&&&&&&&%%&&&&&&&&%%%%&&&&&&&&&&&&&&&&&%%%&%%%%%%%%%#(&&&&&&&&###/,*///*,.....,****,,,,....................
%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&%#(###&&%%&&&&&%%&&&&%%%%%%%&%%%%#%&&&&&&&&&&&%*##(#####((((((////******,,,,,,,*******....
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&((%%&%%&&&&%&&&&&&&&&&&&&&/#%&&&&&&&&&&&&%#*(//((#(((((((((///////****///////////(//
%%%%%%%%%%%%%%%%%%%%%%%&&%%&&&&&&%%%%,#%&&&&%%&%#####%&&&&&&&%(#&&&&&&&&&&&%%%%%#**/*//(((((((((((((((///////(((((((((((
%%%%%%%%%%%%%%%%%%%%%%%&&%&&&&%%%%%%%/#&&&&&%%%%#####%&&&&&&&&%%(&&&&&&&&&&&&%%%%%%#((##(/*#///######(((((((((((########
%%%%%%%%%%%%%%%%%%%%%%&%&&&&&&%%%%%%((%&&&&&&&&%%%%&&&&&&&&&&&%##%%&&&&&&&&&&&&&%%%%%%%%%%%#/**//#####################%%
%%%%&%%%%%%%%%&&&%%%%%%&&%#%%%&%%&&%/(%&&&&&&&&&&&&&&&&&&&&&&%(###(/(%&&&&&&&&&&%&%%%%%%%%%%%##(/((((###%%%%%%%%%%%%%%%%
%%%%%%%%&%%%&&%&&&&&&%%%&%%%%%###%%#((&&&&&&&&&&&&%%%%&&&&&&&&%#%%%%&&&&&&&&&&&%&&%%%%%%%%%%%%%%%#,#(#%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%&&&%&&&&%%##%%%%%%%((##/%%&%%%%%%%%%&&%&&&&%%%%%%##%&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%##*##(%%%%%%%%%%%%%%%
&%&&&&&&%%&%%%%%&&&%%%%#####%%%%(%%(%#%%%%%%%&&&%%%%%%%%%%#%&&&&&&&&&&&&&&&%&&&&&&&&%%%%%%%%%%%%%%%%%%%#/##%%%%%%%%%%%&&
####(##%%%&&&&&&%%%%%%%%###%%%%%%%%%%%%%%%%%%#%#%%%%#%&&&&&&&&&&&&&&&&#%%%%&#&%&&&&&&&&&&%%%%%%%%%%%%%%%%#/%(%&&&&%%%&&&
#%#################%%%%%%&&%%%%(###%%%%%((%%&&&%&&&&&&&&&&&&&&&%(#(((######(######%%%%%&&&&&&&&&%%%%&&%%%%%#%%&&&&%%%%%%
%####%###%#%#%#%#%%%%&&&&&&&&%%%(######%%%%%%#&%#%%##(#((((#((((((((((((#(###########%%&&&&&&&&&%%&&&&&&&%%%%%%%%%%%%%%%
%%%%%%%#%%%#%####%%&&&&&&&&&%%(%###%%#%%#%%%##(#####%#######(%###%%%%#%####(##(((#((###%%&&&&&&&%&&&&&&&&&&&%%%##%%%%%%%
&%&%%%%%%%%%%%%%#%&&&&&&&&&&((%##%%###########(#%##(#((((#((((((###(#/((####(#((((((#%%%&&&&&&&%%&&&&&&&&&&&&%%#########";
        string _3 = @"
******************************///////////////////////(((((((((((((((((#######################################%%#%%%%%%%%
,,,,,,,***************************/////////////////////////////(((((((((((((((((((((((##################################
,,,,,,,,,,,,*****,,,*************************************//////////////////((((((((((((((((((((((((((((#################
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************************///////////////////////(((((((((((((((((((((((((((((((((
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************///////////////////////////////((((((((((((((((((((
...................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************************////////////////////////////////(((((((
...........................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************/////////////////////////////
.....................................,,,,,,,,,,,,,,,(%(,,,,,,,,,,,,*******************************//////////////////////
#####/,......................................,,,,(&&&&&&&%,,,,,,,,,,,,,,,,,,*********************************///////////
##############*................................,#&&&&&&&&&&*,,,,,,,,,,,,,,,,,,,,**************************************//
#######%%%%%%%%%%%%%%%%%%%/...................*#%%&&&&&&&%*,,,,,,,,,,,,,,,,,,,,,,,,,************************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#(.........../*(&&&&&&&&/,..,,,,,,,,,,,,,,,,,,,,,,,,,,**********************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#///%&&&&&&&&&,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************
##%%%%%%%########%%%%%%%%%%&&&%%%%%%%%%%%#(*(%&&&&&&&&&&&%%%%&%(,,,,,,,,,,,,,,,,,,,,*,**********************************
##########%##%%%##%###########%%%%%%###%%(*/%&&&&&&&&&&&##%%%%&&&&&&&&&&%%&&%%##(//*************************************
###############################%%%%%%&%%%/*/%&&&&&&&&&&&##%%%%%%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%#(/*/**********
#####%%%#%%%%%###########################**#&&&&&&&&&&&&%%%%%%%%%%#####%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&(/
##%%%%%#################################*,/%%&&&&&&&&&&&##(%&&@%%###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%#%##%%%%%%########%#####%%%%%%%%##,*/%&&&&&&&&&&&&&%(/&&&&&&%#######%#################%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%&%%%%%%%%%%%%%%%###%%%%%%/*/#%&&&&&&&&&&&&&&*/#&&&&&&&&&%%%%%%##%%%#############%######%%%%%%%%%%%%%%%%%%%%%
##%#####%%%#%%#%%########%##%%%%%%%%((*%&&&&&&&&&&&&&&&&(*##&&&&&&&&&&&&&%%&%%%&%#%%%%%%%%&&&&&&%###########%%%%%%%%%%%%
(((((((((((((((((((((((/((((((((((((/(#&&&&&&&&&&&&&&%&&&&&%%%&&&&&&&&&&%%%%%%%&&%%%%%%%%%&&&%%%%%%%%%%%%##%#%%%%%%%%##%
#######(###%####(######%#####(#((((#((#&&&&&&&&&&&&&&%#&####%%%&&&&#((((((##(########((#((((((#(############(#(#########
####(###########################%#%%#(#&&&&&&&&&&&&&&&%##%%#%%%%%%%%(###########(####(####%%%############%%%%%%%%%%%%%%%
%%%%%%%%%##########(#(################%&&&&&&&&&&&&&&&%####%%%%%%%%%%####(#######%%%%%######%##%%%#####################%
&%%%%&&%%%%%%%########%###############%&&&&&&&&&&&&&&&%##%&#%%%%%%%%%#####%%%%%%%%##%%%%%%%#%#%%%####%##%%%#%#####%##%%%
&&&&&&&&&&&&&&%%%%##%%%&&%%%%######(#(&&&&&&&&&&&&&&&&&##(#/%%%%%%%%%%%&%%%%#%%%%%%%%%%%%%%%#%%%%%%%#%###%%%##%%%%%%%%##";
        string _30 = @"
////////////////////////////////////****/*,**,***,******////*****,,,************************************************////
///////*******//**/////*********,,************,,*,,,/**,,,,,**,,,,,,,,,,,,**********************************************
*/*//***********************///,,,*****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
#/************************,,*,,,*************,,**,,,,,,,,,,,,,*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
%%%%%%%%%#********,,****,,,,,,**,,,,,,,,,,,,,**********,,,,,...,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%*,*,,,,,,......,,.,,,,..,..,,,,,.......,,...,,,,,,......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%&&&&&&%*.,.,,,........,,,,,,,..,,.............,,,..................................,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&,.......,.....................................................................,,,,,......
%%%%%%%%%%%%%%%&%%&&&&&&&&&&&&&&&&&&%%%.................................................................................
%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&%%%&&%%%............................................................................
%%%%%%%%&&&%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%####((((((#/..........................................................
%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%#########((((((/*,,,,,...........................................
&%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%&&&&&&&&&&&&&&&&&%%%&%%%%%%%%%%#%&&&&&&&&&%/**//**......,****,,,.....................
%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&#(%%%%&&&&&%%&&&&%%%%%%%&%%%%%(#&&&&&&&&&&&&%#*#/###((((((////******,,,,,,,******,....
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&/#%%%%&&&&%&&&&&&&&&&&&&&%(##&&&&&&&&&&&&&&#**//((((((((((///////****///*//////////
%%%%%%%%%%%%%%%%%%%%%%%&%%%&&&&&&&%%%#*%&&&&%%&%#####%&&&&&&&%%(#%&&&&&&&&&%%%%%%%%#****////((((((((((/////////(((((((((
%%%%%%%%%%%%%%%%%%%%%%%&&%&&&&&%%%%%%(/&&&&&%%%%#####%&&&&&&&&&%/%%&&&&&&&&&&&%%%%%%%%%%%%%#**,*/(((((((((((((((########
%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%%%%(*#&&&&&&&&%%%&&&&&&&&&&&&&#((%%%%&&&&&&&&&&%%%%%%%%%%%%%%#/*((###################%%
%%%%%%%%%%%%%%&&%%%%%%%&&%%%%#%%%&&%*/#&&&&&&&&&&&&&&&&&&&&&&&&((#(**(%&&&&&&&%%%%%%%%%%%%%%%%%##(/*/(##%%%%%%%%%%%%%%%%
%%%%%%%%&%%%&&%&&&&&&%%&%%%%%%%%(###(#&&&&&&&&&&&%%%%%&&&&&&&&&&&%%%&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%#/(#/%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%&&&%&&&&%%%#%%%%%%%(#%%##%&&%%%%%%%%&&%&&&&%%%%%%%##%&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%%#(/#(%%%%%%%%%%%%%
&%&&&&&%%&&%%%%%%&%%%%%######%%%%%%#%#%%%%%%%&&&%%%%%%%%%%##%&&&&&&&&&&&&&&%%&&&&&&&&&%%%%%%%%%%%%%%%%%%%#(%(%%%%%%%%%&&
###((###%%&%&&&&#%%%%%%%###%%%%%%%%%%%%%%%%%%%%#%%%%%#%%&&&&&&&&&&&&&&#%%%%&#%%%%&&&&&&&&%%%%%%%%%%%%%%%%%%#/%#&&&%&&&&&
#%#################%%%%%%%&&%%%(####%%%%/(##%&&&&&&&&&&&&&&&&&%%(#(#(######(##########%&%&&&&&&&%%%&&&&&&%%%%#%#&%%%%%%%
%####%%%#%%%##%%#%%%%&&&&&&&%&%((#####%#%%%%#(#%#%%%%(#((((#(((((((((#(##(#############%&&&&&&&&%%&&&&&&&&&&&%%%#%%#%%%%
%%%%%#%#%%%#%%%#%%%&&&&&&&&&%%(%#%(%%###(%%%#####%##%#######(%###%%%%#%####(##(((#((((####&&&&&&%&&&&&&&&&&&&&%#%%%%%%%%
&&&%%&%%%%%%%%%%##%&&&&&&&&&&(%#(%(#(#%(####%(####%##(((##(/((((((#(#(((####(#(((/((((%%&&&&&&&%%&&&&&&&&&&&&&&%%#######";
        string _31 = @"
////////////////////////////////////****/*,**,***,******////*****,,,************************************************////
///////*******//**/////*********,,************,,*,,,/**,,,,,**,,,,,,,,,,,,**********************************************
*/*//***********************///*,,*****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******************
%#************************,,*,,,,************,,**,,,,,,,,,,,,,*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
%%%%%%%%%%********,,****,,,,,,**,,,,,,,,,,,,,**********,,,,,...,,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%*,,,,,,,,,.....,,.,,,,..,..,,..,.......,,...,,,,,,......,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%&&&&&&&*.,.,,,........,,,......,,..................................................,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&,........................................................................................
%%%%%%%%%%%%%%%&%%&&&&&&&&&&&&&&&&&&%%#.................................................................................
%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&%%%&&%%%............................................................................
%%%%%%%%&&&&%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%####((((((#/..........................................................
%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%#########((((((/,,(/%#,..........................................
&%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%&&&&&&&&&&&&&&&&&%%%&%%%%%%%%%%##&&&&&&&&&&%%****,......,****,,,.....................
%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&%/#%%%&&&&&%%&&&&%%%%%%%&%%%%%%/%&&&&&&&&&&&&%%#,(((((((((////****,,,,,,,,,,****,.....
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&#/%&%%&&&&%&&&&&&&&&&&&&&%%%/%&&&&&&&&&&&&&%%#*,//((((((((//////*****//*///////////
%%%%%%%%%%%%%%%%%%%%%%%&%%&&&&&&&&%%%%*%&&&&%%%%#####%&&&&&&&%%&#(&&&&&&&&&%%%%%%%%%%#*,,**/*/(((((((/////////((((((((((
%%%%%%%%%%%%%%%%%%%%%%%&&%&&&&&%%%%%#(#%&&&&%%%######&&&&&&&&&&&&%#&&&&&&&&&&&%%%%%%%%%%%%%###*.,(((((((((((((((########
%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%%%%(,(&&&&&&&&%%%&&&&&&&&&&&&&&%((%%%%&&&&&&&&&%%%%%%%%%%%%%#####/####################%
%%%%%%%%%%%%%%&&%%%%%%%&&%%%%%#%#&&(*#/&&&&&&&&&&&&&&&&&&&&&&&&&&/%***%&&&&&&&%%%%%%%%%%%%%%%%%%%##*,/##%%%%%%%%%%%%%%%%
%%%%%%%%&%%%&&%&&&&&&%%&%%%%%%%%(((#(#&&&&&&&&&&&%%%%%&&&&&&&&&&&&&%&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%###(*%%%%%%%%%%%%%%%%
%%%%%%%%%%%%&&&&%&&&&%%%##%%%%%%%#%%#%%&%%%%%%%%%&&%&&&&%%%%%%%&#%&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%/*%%%%%%%%%%%%%
%%%&&&&%%&%%%%%%%&%%%%%%#####%%%%%%%%#%%%%%%%&&&%%%%%%%%%%%#%%&&&&&&&&&&&&&%%%%&&&&&&&%%%%%%%%%%%%%%%%%%%%%#/%%%%%%%%%&&
###(####%%&%&&&&#%%%%%%%###%%%%%%##%%%%%%%%%%%%%#%#%%##%&&&&&&&&&&&&&&#%%%&%#%%%%&&&&&&&&%%%%%%%%%%%%%%%%%%%%#(&&&%%&&&&
#%#################%%%%&%&%%&%%#####%%%%/(#(#&&&&&&&&&&&&&&&&&%(##((##(####(##########%&#&&&&&&&%%%&&&&&&&&%%%%/%%%%%%%%
%####%%%%%%%##%##%%%%&&&&&&&%%%(####%#%#%%%%(/(%%%%%%(((#(((((#((((((#(##(##(##########(&&&&&&&&%%&&&&&&&&&&&%%%(%%%%%%%
%%%%%#%#%%%%%%%%%%%&&&&&&&&&%&(%#%(#%#####%%(#%##%#%#########%###%%%%%%####(##(((#((((((##&&&&&&%&&&&&&&&&&&&&&&%%%%%%%%
&&&%%&%&%%%%%%%%%%%&&&&&&&&%%###(############(#####(#(((##((((((((#(((((####(#(((/(((/%&&&&&&&&%%&&&&&&&&&&&&&&&%#######";
        string _32 = @"
////////////////////////////////////******,**,***,******////*****,,*************************************************////
///////*******//**/////*********,,************,**,,****,,,,,**,,,,,,,,,,,,**********************************************
*/*//***********************///*,,*****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******************
%%/***********************,,,,,,,,***********,***,,,,,,,,,,,,******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
%%%%%%%%%%#*******,,****,,,,,,,,,,,,,,,,,,.,,**********,,,,,..,,,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%*,,,,,,,,,,....,,.,,,,..,.,,,..........,....,,,,,,.....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%&&&&&&&(...,,,........,,,......,,................................................,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&%.........................................................................................
%%%%%%%%%%%%%%%&%%&&&&&&&&&&&&&&&&&&%%/.................................................................................
%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&%%%&&%%%............................................................................
%%%%%%%%&&&&%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%#####(((((#(*..........................................................
%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&##########((((((*/%%%&%#(/........................................
&%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%#%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%(%&&&&&&&&&&&##,,.......,****,,,.....................
%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&%/%#%&&&&&%&&&&%%%%%%%%&%%%%%%#*#&&&&&&&&&&&&%%#/*(((((////******,,,,,,,,,*****......
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%,%%%%%&%%%&&&&&&&&&&&&&&%%%#*%&&&&&&&&&&&&&%%#(*,///(((((//////*****//*///////////
%%%%%%%%%%%%%%%%%%%%%%%&%%&&&&&&&&%%%%/(&&&&%%%######%&&&&&&&%%&%%(%&&&&&&&%%%%%%%%%%%(/*,,****/(((((/////////((((((((((
%%%%%%%%%%%%%%%%%%%%%%%&%%&&&&&&%%%%%/##&&&%%%%######&&&&&&&&&&&&&%%/&%%&&&&&&%%%%%%%%%%%%%%##(/*,,/*(((((((((((########
%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%%%#*/*%&&&&&&%%%%&%&&&&&&&&&&&&&%((%%#%%&&%%%%%%%%%%%%%%%%%%%####(#*##################%
%%%%%%%%%%%%%%&&%%%%%%%&&&%%%%%//%&(/(/%&&&&&&&&&&&&&&&&&&&&&&&&&&&*%#(%&&&&&&&&%%%%%%%%%%%%%%%%%###(//#%%%%%%%%%%%%%%%%
%%%%%%%%%%%%&&%&&&&&%%&&%%%%%%%%((/%/#%&&&&&&&&&&%%%%%&&&&&&&&&&&&&%%%&&&&&&&&&&&&%%%%%%%%%%%%%%%%%#%%##((%%%%%%%%%%%%%%
%%%%%%%%%%%%&&&&&&&&&%%%###%%%%%%%#&(%&&%%%%%%%%%&&%&&&%%%%%%%&&&#%&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%#,%%%%%%%%%%%%
%%%&&&%#%&%%%%%%%%%%%%%%#####%%%#%%%%%%(%%%%%&&&%%%%%%%%%%%&(%%&&&&&&&&&&&&%%%%%%&&&&&%%%%%%%%%%%%%%%%%%%%%%%/%%%%%%%%&&
########%%%#&%%%%%%#%%%%%##%%%%%(##%%#%%%%%%%%%%%%/%%(##%&&&&&&&&&&&&&#%%%&#%%%%%%%&&&&&&%%%%%%%%%%%%%%%%%%%%%%*&&%%&&&&
###################%%%%&%&%%&%%%####%%%/(###(#%%&&&&&&&&&&&&&&%(#((######(##########%%%%%%&&&&&&%%%&&&&&&&&&%%%%#%%%%%%%
%###%%%%%%#%%%%###%%%&&&&&&&&%%##%#%%#%%%%((((#(#%%%##(#((((((#(((((((((((##(###(########%&%&&&&%&&&&&&&&&&&&&%%%#%%%%&&
%%#%%#%%#%%%%%%%%%%&&&&&&&&&&((%##(######%%%########%####(###%###%%%%%#####(((#((##((((((&#%&&&&%&&&&&&&&&&&&&&&&%%%%%%%
&&&&&%%&%%&%%%%%%%%&&&&&&&&%%(##################(##(#((#(##((((#((#(((##(###(((*(///#(%%&&&&&&&%&&&&&&&&&&&&&&&&&&######";
        string _33 = @"
////////////////////////////////////******,*****,,******///*,***,,,*************************************************////
///////*******//**/////*******,*,,************,**,,****,,,,,*,,,,,,,,,,,,***********************************************
*/*//***********************///*,,,****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******************
%#/**********************,,,,,,,,************,***,,,,,,,,,,,,******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
%%%%%%%%%%#*******,,****,,,,,,,,,,,,,,,,,,,,***********,,,,,..,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%*,*,,,,,,,.....,,.,,,,.,,.,,,.,........,...,,,,,,......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%&&&&&&&,,..,,.........,,,......,,,...............................................,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&/,.......,................................................................................
%%%%%%%%%%%%%%%&%%&&&&&&&&&&&&&&&&&&%%,.................................................................................
%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&%%%&&%%#............................................................................
%%%%%%%%&&&&%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%#####((((((/...........................................................
%%%%%&&&&&&&&&&&&&&&&%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&###(#####((((((*.*%%&&&&%(,,......................................
&%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%#%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%(#&&&&&&&&&&&%%,.........,**,,,......................
%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&%(##%&&&&&%&&&&%%%%%%%%&%%%%%%%/(%&&&&&&&&&&&&%%*//((((////*****,,,,,,,,,,****.......
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%,#&%%%&%%%&&&&&&&&&&&&&%%%%%/(%&&&&&&&&&&&&%%%#*,**///(((/////*******/*///////////
%%%%%%%%%%%%%%%%%%%%%%&&&%&&&&&&&&%%%%/(&&&&%%%######&&&&&&&&%%%#%##%&&&&&&%%%%%%%%%%%#(,,,***/*/((((/////////((((((((((
%%%%%%%%%%%%%%%%%%%%%%%&%%&&&&&&%%%%%/(#&&&%%%%######&&&&&&&&&&&&&#%(#&%&&&&&&%%%%%%%%%%%%%%###(*,***/(((((((((#########
%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%%%#***%&&&&&&%%%%&%&&&&&&&&&&&&&%###%#%%#%%%%%%%%%%%%%%%%%%%%#####(*(#################%
%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%#((%%//#(%&&&&&&&&&&&&&&&&&&&&&&&&&&&(%((#%&&&&&&&%%%%%%%%%%%%%%%%%###(*#*%%%%%%%%%%%%%%%%
%%%%%%%%%%%%&&%&&&&&%%&&%%%%%%%%(((%/%%&&&&&&&&&%%%%%%&&&&&&&&&&&&&%%%&&&&&&&&&&&&%%%%%%%%%%%%%%%%%#%%%#(%(%%%%%%%%%%%%%
%%%%&%%%%%%%&&&&&&&&&%%%###%%%%%%%/%(%&%%&&%%%%%%&&%&&&%%%%%%%&&&%%%&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%#*##%%%%%%%%%%
%%&&&&%(%%%%%%%%%%%%%%%%#####%%%#%%%%%%#%%%%%&&&%%%%%%%%%%%&(#%&&&&&&&&&&&&&#%%%%&&&&&%%%%%%%%%%%%%%%%%%%%%%%/#%%%%%%%&&
##(#####%%%%%%%%%%%#%%%%%###%%%%/#%%(#%%%%%%%%%%%%/#%####%&&&&&&&&&&&&%%%%&(%%%%%%%&&&&&&%%%%%%%%%%%%%%%%%%%%%%/#%%&&&&&
###################%%%%&%&&&&%%%####%%#((##((##%&&&&&&&&&&&&&&&##(((##((###########%%%%%%%%&&&&&%%%&&&&&&&&&%%%%#%%%%%%%
%%##%#%%%%%%%%#%%#%%%&&&&&&&&%%#######%#%#((((((#%%%%#(#((((((((((((((/##(######(########%%%&&&&%&&&&&&&&&&&&&%%%#%%&&&&
%%#%#%%%#%%%%%%#%%%&&&&&&&&&&%#%#%#%#(#%#%#######(#######(#######%%%%%##(###((#((#(((((((%%%&&&&%&&&&&&&&&&&&&&&&%%%%%%%
%&&&&%&&%%%%%%%%%%%&&&&&&&&%&###################((#(#((((((((((((((/(((%#((#((/(//((#(%%&&%&&&&%&&&&&&&&&&&&&&&&&&%#####";
        string _34 = @"
////////////////////////////////////********,***,*******///*,***,,,*,**********************************************/////
////////******//**/////*******,,,*************,*,,*/**,,,,,**,,,,,,,,,,,,***********************************************
*/*//**********************///*,,,,***************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
%#/**********************,,,,,,,************,,***,,,,,,,,,,,,*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****
%%%%%%%%%%/******,,,***,,,,,,,,,,,,,,,,,,.,,**********,,*,,.,.,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*
%%%%%%%%%%%%%%%%%%,*,,,,,,,,.....,...,,..,..,,,.,...,...,,...,,,,,,.....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%&&&&&&#,,..,,.........,,,,....,,,,.......,,...,..................................,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&/.........................................................................................
%%%%%%%%%%%%%%%&%%&&&&&&&&&&&&&&&&&&%%..................................................................................
%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&%%%&&&%%,............................................................................
%%%%%%%%&&&&%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%####(((((((,...........................................................
%%%%%%%&&&&&&&&&&&&&&%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%##((####(((((((,.*&&&&&&&%%#,,....................................
&%&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%(#%%&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%#(#&&&&&&&&&&%%%/,........,,,........................
%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%#%&&&&&%&&&&%%%%%&%&%%%%%%%%%*(%&&&&&&&&&&&%%%#*/*//////****,,,,,,,,,,,,**,.......
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&/*%%%&&&%&&&&&&&&&&&&&&%%%%%%/#%&&&&&&&&&&%%%%%#(*,**////////*********////////////
%%%%%%%%%%%%%%%%%%%%%%&&%%&&&&&&&&%%%%//%&&%%&%#####%&&&&&&&%%%%%%%/#%%&&&&%%%%%%%%%%%%#(/******(*/(/////////(((((((((((
%%%%%%%%%%%%%%%%%%%%%%&&%%&&&&&&%%%%%#/#&&&%%%%#####%&&&&&&&&&&&&&&&#/#%%&&&&&%%%%%%%%%%%%%%####(/,,,,/((((((((########(
%%%%%%%%%%%%%%%%%%%%%&%&&&&&&&&&&%%#//*#&&&&&&%%%&&&&&&&&&&&&&&&%%&#(##((/#&&%%%%%%%%%%%%%%%%#######(/((##############%%
%%%%%%%%%%%%%&%%%%%%%%%&&&%%%%%%%##/(#(%%&&&&&&&&&&&&&&&&&&&&&&&&&&&%##/%%&&&&&&%%%%%%%%%%%%%%%%%######*%(%%%%%%%%%%%%%%
%%%%%%%%%%%%&%%&&&&&%%%&%%%%%%%%%(((/%&&&&&&&&&&%%%%%%&&&&&&&&&&&&&&&&%&&&&&&&&&&&%%%%%%%%%%%%%%%%#%%%%%%#/%#%%%%%%%%%%%
%%%&&%%%%%%&&&&&&&&&&%%%####%%%%%%%((#&%%%%%%%%%%&%%&&&%%%%%%%&&&&&%%&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%/#/%%%%%%%%%
%%&&&&%#%%%%%%%%%%%%%%%%######%%%((%%%%%##%%%&&%%%%%%%%%%%%%%(#%&&&&&&&&&&&&#%%%%%&&&&%%%%%%%%%%%%%%%%%%%%%%%%(%(%%%%%&&
########%&%%%&&%%%##%%%%%###%%%%(#%(((#%%%%%%%%%%%%(%####(%%&&&&&&&&&&&#%%%(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(%%&&&&&
###################%%%%%%&&&&%%%(##%(##((((((#(#%&&&&&&&&&&&&&&&%(#(##((##(########%%%%%%%##&&&&%%&&&&&&&&&&&&%%%#%%%%%%
#######%%%%#%%#%##%%%&&&&&&&&%%%#%#%%#%(###(#((((##%%#(#(((((((((#(((((##(######(#########%&%&&&%&&&&&&&&&&&&&&%%%#%&&&&
%%%%#%%##%%%%%%%%#%&&&&&&&&&&#%##%#########(###(#####((##(((%##%#%%%%%#######(#((#((((((((%%&&&%&&&&&&&&&&&&&&&&&%%%%%%%
&&%%&%%%&&%%%%%#%%%&&&&&&&&%&%#################(((#(((((((((((((/((((((#((#((((###%%&#%%&&&&&&%&&&&&&&&&&&&&&&&&&&&%###%";
        string _35 = @"
/////**/**************/**////*/////*,,,,*,,*,***,***,***///*****,,,*,,**********************************************////
*******************///*********,,,***********,,**,,***,,,,,,,,,,,,,,,,,,,***,,,,****************************************
***************************////*,,,**********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********
#%(**********************,,,,,,,,,**********,***,,,,,,,,,,,,,*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%#,,*,,*,,,***,,,,,,,,,,,,,,,,,,,.,*********,,,,,,...,,,,,,,.............................,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%/,/,,,,,,,....,,..,.,,....,,..........,..................................................,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%&%%%,..,,,........................................................................................
%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&(.........................................................................................
%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&%#..................................................................................
%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%%%&&%%%*............................................................................
%%%%%%%%%%%%%%%%%%%%%%%&&&%&&&&&&&&&&&&%%%%%%%%%%###((((((((*... ..........,,,,,,,......................................
%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%&&&&&&&&&&&&&&&&&&&&&&&%##(((((((((((((*.*&&&&&&%%%%%#,...................................
%%%%%%%%%%%%&&&&&&&&&%%&&&&&&%%%%%(#%%&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%(/#&&&&&&&%%%%%%#,......,,,,........................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&%((%&&&%%&&&%%%%%%%%&%%%%%%%%%%//#&&&&&&&&%%%%%%#/,**///****,,,,...,,,,,,,,........
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%#,#%%&&&%&&&&&&&&&&&&&&%%%%%%%(%%&&&&&&&%%%%%%####(*,,*****************///////////
%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%%%%%#(#&&%%%%#####%&&&&&&&%%&%%%%%(##%%&&%%%%%%%%%%%%####((((((,//***////////(((((((((
%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%%%%#*/&&&#%%######%&&&&&&&&&&&&&&%#(/%%%%%%%%%%%%%%%%%%%########((,,,//(((((((((((((((
%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%##(*/%&&&&%%&%&%&&&&&&&&&&&&%%%%%%/#/**/#%%%%%%%%%%%%%%%#########(((*((##############
%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%%#(///##%%&&&&&&&&%%%&&&&%%%%%&&&&&&&&&&(((%%%%%%%%%%%%%%%%%%%%###########*#(######%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%&%#%%%%%%%%#(((%%%%%&&%%%%%%%%%&&&&&&&&&&&&&&&&%#%%%%%%%%%%%%%%%%%%%%%%%%%%##%%%%%%%#/(#%%%%%%%%%
%%%%%%%%%%%%%%%%&&%%%%%%########%%%%#(#%%%%%%%%%%%%%%&&%%%%%%%%&%&%%%%&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%#*##%%%%%%%
%%%%%%#%%%%%%%%%%%#%%%%%%######%%(/%%%%%%%%##%%%%%%%%%%%%%%%%%###%%&&&&&&&&&(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%/#%%%%%%
###((((#%%%%%%%%%%##%%%%%%%%%%%%%((/((####%%%%%%%%%%#####((#%%%&&&&&&&&#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%
###########(######(#%%%%%%%%%%%%((##/(((((((((((#%%%%%%%%&&%&&%%%#(((#(#(((##(((#####%%%%%%#%%%%%%%%%&%%%%%%%%%%%%%##%%%
#########%%#######%%%%%%%%%%%%%%######%%##((((((((((##(#((((((##(#((((((((((((#(((##((((###%##%%%&&&&&%%%%%&&&&%%%%%%%%%
%%###%###%%###%###%%%%%%%%%%%%%(#######((##(##((#(#(#((##((/####%#%%%%###(((#((#(((((((((*#%%%%%&&&&&&&&&&&&&&&&&%%%%%%%
&&%%&%%%%%%%%%%%%%%%%%%%%%%%%%(##############(#(#((((#((#(((((/(((((((((((((((((%%%#(%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&%%###";
        string _36 = @"
************************************,,,,,,,*,***,**,*,**//******,,,*,***************************************************
********************/*********,,,,***********,,,,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********
*************************,**//*,,,,*****,,,,,,,,,,,,,,.,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
##/*********************,,,,,.,,,,**,,,*****,**,,,,,,,,,,,,,,*,,*,,,,,........,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
######%%%%#,,,,,,,,,,,,,,.,,,,,,....,,,,,..,**,,*,*,,,,,,,,....,,,,,.......................................,,,,,,,,,,,,,
###%%%%%%%%%%%%%%%(*,,,,..............,.............................................................................,,,,
###%%%%%%%%%%%%%%%%%%%%%%%..............................................................................................
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%,.........................................................................................
%%%%%#%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%%(..................................................................................
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%%%%%%%%%.....  . . ..                     ...........................................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%%%%%%%%%%%#(((((((((((*.         ....*,(##%#......................................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%&&&&&&%%%%%%&&%%&&%##(((((((((((((/,.*%%&&%%%%%%%##...................................
%%%%%%%%%%%%%%%%%&%%%%%%%%%%%%%&&&&#(%&&&&&&&&&%&%%%%%%%%%%%%%%%%%%##*/%&&&&%%%%%%%%##* .....,..........................
%%%%%%%%%%%%%%%%%&&%%%%%%%&&&&&&&&&&&&(/%%&%%%%&&%%%%%%%%%%%%%%%%%###*/&&&&&%%%%%%%%%##(.,*/****,,,,,......,,,,,........
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%,/%%%%%%&&%&&%&&&&&&&%%%#%%#%%#%%%&&&%%%%%%######((*..,**,****************///////
%%%%%%%#####%%#####%%%%%#%%&&&&&&%%%%%(((%%%%%######%&&&&&&%%%&%%#%%###(#%%%%%%%%%%%%######((((((//,*,,////////////(((((
%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%%%%(,,%&%%########&&&&&&&&&&&&&&%%%%/#%%%%%%%%%%%%%%##########(((((/,//(/(((((((((((((
%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%%&%%##(((#%%&&%%%%&%&&&&&&&&&&&%%%%%%%%((*,*/%%%%%%%%%%%%###########((((/**((((((########
%%%%%%%%%%%%%%%%%%%%%%%#&%%%%%%%##*/*(%%%&&&&&%%&%%%&&&%%%%%%&%&%%%%%%%%*,%%%%%%%%%%%%%%%%################(*############
%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%#(#/#%%%%&%%%%%%%%%%&&&&&&&&%%%%%%%%%(%%%%%%%%%%%%%%%%%%%%%%%%#############*######%###
%%%%%%%%%%%%%%%%%&%%%%%%#(#######%%%%#/%%%%%%%%%%%%%&%&%%%%%#%%&%&%%#%%%%%%%%%%&%#%%%%%%%%%%%%%%%#%%%%%%%%%%%##((##%%%%%
%%%%%##%%%%%%%%#%%#%#%%%##((((#%%%#%%%%%%%%#(%%%%%%%%%%%%%%%%#%#(%%%%%%%%&&%(%%%%%%%%%%%%%%%%%%%##%%%%%%%%%%%%%%#/##%%%%
#((((((#%%#%%%%%%###%%%%%%%%%%%%%(((((#####%%%%%%%%%%(####((%%%%%%%%%%%%%%#%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/%%%%
######(###((((##(#(%%%%%%%%%%%%%%//((((/(((((((((#%%%%%%%%%%&%%%%#(#(((#((((((((######%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#(%%%
################(##%%%%%%%%%%%%%#####%%###((((/(((((((((((/(((#((((((//(((((((((((((((((((((%(%%%&&&&%%%%%%%%%%%%%%%#%%%
%%#######%#%##%####%%%%%%%%%%%%###%#((##(##((#((((#((/(#(/((####%#%#%####((((((((((((((//*#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
&&%%&%&%%%%%%%%%%#%%%%%%%%%%%%/######(#((####(#((/((((((((/(/(/(((((((((((((((((#%%/*#%%%%%%%%%%%%%%%%%&&&&&&&&&&&%%%###";
        string _37 = @"
***********************************,,,,,,,,,,*,,,,,,,,**/**,,**,,,,,,*,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,********************
******************************,,,,******,,,,,,,,,,*,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
***************,********,,*****.,,,,,,,,,,,,,,,,,,,,....,,,,........,,,......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
##*****,,,,,,,**,*****,,,,,...,,,,,,,,,****,,,,,,.,,,,,,,,.,,,,,,,......................................,,,,,,,,,,,,,,,,
##########*,,,,,,,,,,,,,...,,,,....,.......,,,,,,,,,,,,,,......,,,,...............................................,,,,,,
########%%%%%%%%%(*,,,................,.................................................................................
#########%%%%%%%%%%%%%%%%(..........   ..............  .................................................................
#######%%%%%%%%%%%%%%%%%%%&%%#,...............................        ...      .........................................
%%#####%%%%%%%%%%%%%%%%%%%&&%%%%%%&%%*........                                    .............. .......................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%%%%%%%%%%#.                                                        ....................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%%%%%%%%%%%%%((((((((((//.             .(#%%%%#(/.                          .........
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#((((((((((((//,. ,%%%%%%%%%%%##/.                                 
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%/#%&%%%%&%%%%%%%%%%%%###########(,#&%%%%%%%%%%###(,   .........                    
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%*(%%%%%%&%%%%%%%%%%%%%#%%%####(,#&%%%%%%%%%%####(/,.,*,*,,,.........,,,,..       
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&%%%**#%%%%%%&%&%%&&&&&%&%%%####%###%%%%%%%%%%#######((/*....,,,,,*,,****************
%%%%%%#############%%%%%#%%&&&&&&%%%%%/*(%%%%#######%&&&&&%%%%%##%%###/((%%%%%%%%%%#######(((((((//*,..****/////////////
%%%##%%%%%%##%%%%%%%%%%%%#%%%&&&&%%%%/,,#%%####(#((#&&%%&&%&&&%%%%%%%%#*%%(##%%%%%##%########((((((((//**/////((((((((((
#####%%%%%%%%%%%%%%%%%%%%%%%&&%#%%(##(/(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*#(/%%%%%%%%%%%#########((((((((/*,(((((((((####
%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%##(/*#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%/,%%%%%%%%%%%%%##########(########(/###########
#%%%%%%%%%%%%%%%%%%%%%%%%(%%%%%%%%##(#(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(%%%%%%%%%%%%%%%%%%###################(/########
%%%%%%#%%%%%%%%%%%%%%%#%#((((((##%%%%%#(%%%%%%%%%%%%%%%%%%%##%%%%%%%%##%%%%%%%%%%(%%%%%%%%%%%%%%###########%%####*#%%%%%
%%#%%###%%%%%##%%#%%(#%%%(((((#%%%(*#%%%%###%(%%%%%%%##%%%%%##%%#/%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%##%%%%%%%%%%%%%%%###%%%%
(((((((%%%%%%#########%%%%%%%%%%%#*(/###(((#%%%%%%%%%#/(##/((#%%%%%%%%%%%#(%##%%###%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%#/%%%
((((((#((#(((((((((#%%%%%%%%%%%%%#(/(((/((((((((((#%%%%%%%%%%%%%%%#(((((/((((((((###%%%#%%%%#%##%%%%%%%%%%%%%%%%%%%%#(%%
#############(###(#%%%%%%%%%%%%%%(#%#%###(((/((((/(((#(((////((((((((/////((((((((((((((((((##(%%%%%%%%%%%%%%%%%%%%%%#%%
#########%#########%%%%%%%%%%%%%(#((/(#((#((((((((#/(/(((/(##(########(((#((((((((//////*(%%%#%%%%%%%%%%%%%%%%%%%%%%%%%#
%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%/###(###((#####(((((((((((((/////(/((((((((/(/((((/%%%%%%%(%%%%%%%%%%%%%%%%%%%%%%&&%%%%###";
        string _38 = @"
***********************************,,,,,,,,,*,,,,,,,,,**/*,,,*,,,,,,,*,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************
*****************************,,,,,***,,*,,,,,,,,,,*,,,..,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
***************,********,,*****,,,,,,,,,,,,,,,,,,,,,....,,,,........,,,......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
##*****,,,,,,,**,,,***,,,,,...,,,,,,,,,****,,,,,,.,,,,,,,,.,,,,,,,......................................,,,,,,,,,,,,,,,,
##########*,,,,,,,,,,,,,...,,,,....,.......,,,,,,,,,,,,,,......,,,,...............................................,,,,,,
##########%%%%%%%(//,,................,.................................................................................
#########%%%%%%%%%%%%%%%%*..........   ..............  .................................................................
#######%%%%%%%%%%%%%%%%%%%%%%%................................         ..         ......................................
%%#####%%%%%%%%%%%%%%%%%%%&&%%%%%%&%%,........                                        .......... .......................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%(.                                                        ....................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%%%%%%%%%%%%%((((((((((//.             *%%%%%%%%#(/                         .........
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/(%%%%%%%%%%%%%%%%(((((((((((((//,. ./&%%%%%%%%%###/,                                
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%%/#%&%%&%%%%%%%%%%%%############/*#&%%%%%%%%%####(*  ........                     
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%,(%%%%%&%%%%%%%%%%%%%#%%%#####(*%%%%%%%%%%%###(((/*..,,,,..........,,,,.        
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&%%%#*/%%%%%%&%&%%&&&&&%%%%#####%###/%%%%%%%%%#######((((*,,,,,,.,,,,**,*************
##%%%%#############%%%%%#%%&&&&&&%%%%%%*#%%%%#######&&&&&&%%%%%##%%###((/#%%%%%%%%%########(((((((//*,,...**////////////
%%%##%%%%%%##%%%%%%%%%%%%#%%%&&&&&%%%/***%####((#((%&%%%&&&&&&%%%%%%%%%(*%,***%%%%%##########(((((((/((//*////((((((((((
#####%%%%%%%%%%%%%%%%%%%%%%%&&%#((#/(#((#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#*#(/%%%%%%%%###########(((((((((((.((((((((####
%%%%%%%%%%%%%%%%%%%%%%%#(%%%%%%%%##(*/#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(/%%%%%%%%%%%%##########(###########*#########
#%%%%%%%%%%%%%%%%%%%%%%%%####%%%%%####*%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(%%%%%%%%%%%%%%%%%#####################*#######
%%%%%%%%%%%%%%%%%%%%%%##%#(((((###%#%%%%%(#%%%%%%%%%%%%%%%###%%%%%%%%%(#%%%%%%%%%(%%%%%%%%%%%%%%###########%%%%###*%##%%
%%%%#%%%%%%#%##%##%%(#%%%#((((#%%%#*#%%#%%%##%#(#%%%%#%%%%%%##%%#((#%%%%%%%%%#%%%%%%%%%%%%%%%%%%##%%%%%%%%%%%%%%%%##/%%%
(((((((#%#%%%#########%%%%%%%%%%%%#(((##(((#((#%%%#%%%%((##/((%%%%%%%%%%%%#%##%%###%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%#/%%
((((((((((((((#((((#%%%%%%%%%%%%%#//(((/(((((((//(/#%%%%%%%%%%%%%%%#((((/((((((((#(##%##%%%%%(%#%%%%%%%%%%%%%%%%%%%%%##%
#############(###((%%%%%%%%%%%%%%%(#(####(((//(/(/(((((((///((((#(((//////((((((((((((((((((/(##%%%%%%%%%%%%%%%%%%%%%%#%
%%####%############%%%%%%%%%%%%%#/(((((((((((/((/((/////(/((((#((#####((((((((((//#//(%#(##%%%%%%%%%%%%%%%%%%%%%%%%%%%%#
%%%%%%%%%%%%%%#%%%#%%%%%%%%%%%%/(##(###((#####((((#((((((((//(/(//(((((((((/(((((#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%##";
        string _39 = @"
***********************************,,,,,,,,,*,,,,,,,,,**/*,,,*,,,,,,,*,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***************
*****************************,,,,,***,,*,,,,,,,,,,*,,,..,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
***************,********,,*****,,,,,,,,,,,,,,,,,,,,,...,,,,,.................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
##****,,,,,,,,**,,,***,,,,,...,,,,,,,,,****,,,,,,.,,,,,,,,.,,,,,,,......................................,,,,,,,,,,,,,,,,
##########*,,,,,,,,,,,,,...,,,,....,.......,,,,,,,,,,,,,,......,,,,..............................................,,,,,,,
##########%%%%%%%(//,.................,.................................................................................
#########%%%%%%%%%%%%%%%%,..........   ..............  .................................................................
#######%%%%%%%%%%%%%%%%%%%%%%(................................         ....       ......................................
%%#####%%%%%%%%%%%%%%%%%%%&&%%%%%%%%#...........                                         ....... .......................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%*                                     . ..              ......................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%%%%%%%%%%%%%((((((((((//.             /%%%%%%%%##(...                  .............
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/(##%%%%%%%%%%%%%%(((((((((((((//,  .*%%%%%%%%%%###(*.                             ..
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&%((%%%%%%%%%%%%%%%%%############/,(%%%%%%%%%%####(/..........                     
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%,/%%%%&%%%%%%%%%%%%%##%%%######/%%%%%%%%%%%###((((*,...,,..........,,,..        
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&%%%#*/%%%%%&%&%%&&&&&&%%%%#####%###/##%%%%%%%#######((((/*****,.,,,,**,*************
##%%%%#############%%%%##%%&&&&&&%%%%%#,(%%%%#(####%&&&&&&%%%%%##%%###(((#%%%%%%%%%########(((((((///*,...**////////////
%%%##%%%%%%##%%%%%%%%%%%%#%&&&&&&&%##/***%####((#((%&%%%&&&&&&%%%%%%%%%(*(,*,*(%%%%%#########((((((((((//*////((((((((((
#####%%%%%%%%%%%%%%%%%%%%%%%&&%%###(//(##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*(/(#%%%%%%%###########(((((((((((,/(((((((####
%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%##(//(#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%/#%%%%%%%%%%%##########(##########(/(########
#%%%%%%%%%%%%%%%%%%%%%%%%####%%%#%####/#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##%%%%%%%%%%%%%%%%#####################*(######
%%%%%%%%%%%%%%%%%%%%%%##%#(((((###%#(%%%%(###%%%%%%%%%%%%%##%%%%%%%%%%##%%%%%%%%%##%%%%%%%%%%%%%###########%%%%###/(##%%
%%%%#%%#%%%#%%#%##%%##%%%#((((#%%%(/#%#%%%%##%#(%######%%%%##%%%#((#%%%%%%%%%#%%%%%%%%%%%%%%%%%%##%%%%%%%%%%%%%%%%####%%
(((((((#%#%#%######(##%%%%%%%%%%%%(/((#((((#((####%%%%%(#((/((#%%%%%%%%%%%%###%%###%%%%%%%%%%%##%%%%%%%%%%%%%%%%%%%%#(#%
(((((((((((((((((((#%%%%%%%%%%%%%%//(((/(((((((//((##%%%%%%%%%%%%%%#((((((((((((#(###%##%%%%%###%%%%%%%%%%%%%%%%%%%%%##%
##########(######(#%%%%%%%%%%%%%%##(#####((((/(/(/(((((((///((((((((//(//(((((((((((((((((((*###%%%%%%%%%%%%%%%%%%%%%%#%
%##################%%%%%%%%%%%%%%((((((((((((/((/(////(////(((##(#(###(((((((((///#/(###(##%%%%%%%%%%%%%%%%%%%%%%%%%%%%#
%%%%%%%%%%%%%%#%%%#%%%%%%%%%%%%(#(((##(#(#####(((((((((((((//(/(///(((/((((/(((//#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%##";
        string _4 = @"
******************************///////////////////////(((((((((((((((((##########################################%%%%%%%%
,,,,,,,****************************////////////////////////////((((((((((((((((((((((((#################################
,,,,,,,,,,,,,,,,,,,,*********************************//**//////////////////((((((((((((((((((((((((((((#################
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************************///////////////////////(((((((((((((((((((((((((((((((((
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************///////////////////////////////((((((((((((((((((((
................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************************////////////////////////////////(((((((
...........................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************/////////////////////////////
.....................................,,,,,,,,,,,,,,*%%/,,,,,,,,,,,********************************//////////////////////
#####(,......................................,,,,%&&&&&&&(,,,,,,,,,,,,,,,,,,*******************************/////////////
##############/................................*%&&&&&&&&&%,,,,,,,,,,,,,,,,,,,,,************************************////
#######%%%%%%%%%%%%%%%%%%%(...................##%&&&&&&&&(,,,,,,,,,,,,,,,,,,,,,,,,**************************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(,.........,//%&&&&&&&&,..,,,,,,,,,,,,,,,,,,,,,,,,,,,**********************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%////&&&&&&&&&&....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************
##%%%%%%%########%%%%%%%%%%&&&%%%%%%%%%%%/(*#&&&&&&&&&&&&%%%%%%#*,,,,,,,,,,,,,,,,,***,**********************************
##########%##%%%#%%%##########%%%%%%###%%**(%&&&&&&&&&&%##%#&&&&&&&&&&&&&&&&%%###((/****,,******************************
###############################%%%%%%%%%%**#&&&&&&&&&&&&###%%%%%%&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%#(**/*********
#####%%%#%%%%%###########################**%&&&&&&&&&&&&%%%%&&&%%%####%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%/
##%%%%%#################################,*#%&&&&&&&&&&&&#((&&&@&%###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%####%%%%%%##############%%%%%%%%##,*#&&&&&&&&&&&&&&#((&&&&&&%#######%#################%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%&%%%%%%%%%%%%%%%##%%%%%%%**/%&&&&&&&&&&&&&&&*/#&&&&&&&&&%%%%%%#%%%%#############%######%%%%%%%%%%%%%%%%%%%%%
##%######%%#%##%%########%###%%%%%%%*/(%&&&&&&&&&&&&&&&&(*##&&&&&&&&&&&&&%%&%%%&%#%%%%%%%%&&&&&&%###########%%%%%%%%%%%%
(((((((((((((((((((((((/((((((((((((*(%&&&&&&&&&&&&&&#&&&&&&%%&&&&&&&%%%&%%%%%&&&%%%%%%%%%&&&%#%%%%#%%%%%###%%%%%%%%%##%
#######(###%####(############(#((((#(/&&&&&&&&&&&&&&&%&%#(%%%%%&&&&#((((((##(###(####((##((((((#(#(#########((##########
#####################%############%%#(%&&&&&&&&&&&&&&&%##%%#%%%%%%%%(#(#########((###(####%%%############%%#%%%%%%%%%%%%
%%%%%%%%%###########((##############%(%&&&&&&&&&&&&&&&#####%%%%%%%%%%####(####(##%%%%%%#####%###%######################%
&%%%%&&%%%%%%%########%#############&#%&&&&&&&&&&&&&&&%(##%%%%%%%%%%%###%#%%%%%%%%%%%%%%%%%#%##%%%###%%##%%#%###%#%##%%%
&&&&&&&&&&&&&&%%%%##%%%&&%%%%######/&(&&&&&&&&&&&&&&&&&##(#/%%%%%%%%%%%&%%%%#%%%%%#%%%#%%%%%%%%%%%%%#%###%%%%%%%%%%%%%##";
        string _40 = @"
***********************************,,,,,,,,,*,,,,,,,,,****,,**,,,,,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***************
**********************,******,,,,,,*,,,*,,,,,,,,,,,,,...,,,,,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
***************,********,,*****,,,,,,,,,,,,,,,,,,,,,...,,,,,.................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
##****,,,,,,,,**,,****,,,,,..,,.,,,,,,,****,,,,,..,,,,,,,,.,,,,,,,.....................................,,,,,,,,,,,,,,,,,
##########,,,,,,,,,,,,,.....,,........,...,,,,,,,,,,,,,,,......,,,...............................................,,,,,,,
##########%%%%%%%#(,,...................................................................................................
#########%%%%%%%%%%%%%%%%...........  ............... ..................................................................
#######%%%%%%%%%%%%%%%%%%%%%%*...............................   ..  .......  ...........................................
%%#####%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%,.......... ...          .. .....        .. .......................................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%*                                   ..,,,... .................................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%%%%%%#((((((((((/*.            .#%%%%%%%%%##(..  .............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%(##%%%%%%%%%%%%%#((((((((((((//.   .#%%%%%%%%#####(*.        .......      .........
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%/(#%%%%%%%%%%%%%%#############(,,#%%%%%%%%####(((/......... .......    .........
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%(,(%%%&%%%%%%%%%%%%%%%%%#######(#%%%%%%%%%%###(((///,.............,,,,..        
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&%%%#*/#%%%%%%&%%&&&&&&%%%%#########((##%%%%%%#######((((///*****,,,,,.,*************
##%%%%############%%%%%##%%&&&&&&&%%%%%,,(%%##(####%%&&&&&%%%%%##%####((((%%%##%%%#########((((((//////,..,*////////////
%%%##%%%%%%##%%%%%%%%%%%%%%&&&&&&%%(((*(/(####(#((#%&%%%&%&&&&%%%%%%%%%#(/**,,*(%%%%#########(((((((((((//*///((((((((((
####%%%%%%%%%%%%%%%%%%%%%%%%&&%%%#((///(#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%///(#%%%%%%###########((((((((((((/(/(((((####
%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%####(//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#(#%%%%%%%%%%######################(*(#######
#%%%%%%%%%%%%%%%%%%%%%%%%%(#####(#%####/##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##%%%%%%%%%%%%%%%######################(######
%%%%%##%%%%%%%%%%%%%%###%%#(((((#%##/(%%%%%##%#%%%%%%%%%%%##%%%%%%%%%%%##%%%%%%%%%#%%%%%%%%%%%%############%%%%%%##/(%%%
##%##%%#%%%%%%#%#%%%%###%%#####%%###(#(%%%%#%%%%%########%%##%%######%%%%%%%%%%%%%%%%%%%%%%######%%%%%%%%%%%%%%%%%%%#(%%
(((((((#%%#%########(#%%%%%%%%%%%%#//(#((((((((((###%%%%#(#/(((%%%%%%%%%%%%%##%%###%%%%%%%%%%%##%%%%%%%%%%%%%%%%%%%%%#(#
((((((#((((((#((((((%%%%%%%%%%%%%%%(((//((((((///(((#%#%%%%%%%%#####((((((((((((#((#(##%%%%%####%%%%%%%%%%%%%%%%%%%%%%##
####(#####(#(##(((##%%%%%%%%%%%%%%#######((((/(((/((((((////(((#((((/////(/(((((((((((((((((*#%##%%%%%%%%%%%%%%%%%%%%%%#
%%#%%###%#####(####%%%%%%%%%%%%#%#(((((((((((/(//((///(////((###/#/(#((((((((((///%%#((###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#
%%%%%%%%%%%%%%#%%%#%%%%%%%%%%%%%#((((((((###(##(#((((((((//(/(((////((/(((//(((((#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%%#";
        string _41 = @"
***********************************,,,,,,,,,*,,,,,,,,,****,,**,,,,,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************
**********************,,*****,,,,,,*,,,*,,,,,,,,,,,,,...,,,,,.....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
***************,********,,*****,,,,,,,,,,,,,,,,,,,,,,..,,,,,.................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
##*,**,,,,,,,,**,,****,,,,,..,,.,,,,,,,****,,,,,..,,,,,,,,.,,,,,,,.....................,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,
##########/.,,,,,,,,,,,.....,,........,...,,,,,,,,,,,,,,,......,,,...............................................,,,,,,,
##########%%%%%%%%#,,.................................................................................................,,
#########%%%%%%%%%%%%%%%%,..........  ..................................................................................
#######%%%%%%%%%%%%%%%%%%%%%%#..........................................................................................
%%#####%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%*..................................................................................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%*.                                 .**((((#,..................................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%(##%%%%%%%%%#((((((((((/*.            .#%%%%%%%%%###(................................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%/#%%%%%%%%%%%%#((((((((((((//,    *%%%%%%%%#####((,..............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%*(%%%%%%%%%%%%%%#############((,*%%%%%%%%####((((*.....  . ....................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%%**%%%&%%%%%%%%%%%%%%%%%#########%%%%%%%%%%###((((//*.............,,,,..      ..
%%%%%%%%%%%%%%%%%%%%%%%%%%%#&&&&&&&&%%%%*((%%%%%%&%%&&&&&&%%%%##########(##%%%%%%#######((((((/***/***,,,.,*************
##%%%%############%%%%%##%%&&&&&&&&%%%%,,(%%#######%%&&%%&%%%%%%%%####((#(#%%##%%%#########((((((///////,,.*////////////
%%%##%%%%%%##%%%%%%%%%%%%%%&&&&&&&%#(/*///####(#((#%&%%%&%&&&&%%%%%%%%%##/*,,,**#%%%#########((((((((((((//**/((((((((((
####%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%##(/*(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*.//%%%%%%##########(((((((((((((((*(((((####
%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%#%%#(*%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#((%%%%%%%%%%########################*#######
#%%%%%%%%%%%%%%%%%%%%%%%%%#########%%####(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%#######################(#####
%%%%%(%%%%%%%%%%%%%%%(##%%#(((((#%%##/%%%%%###/#%%%%%%%%%%##%%%%%%%%%%%%##%%%%%%%%#%%%%%%%%%%%%############%%%%%%%##/%%%
##%##%%#%%%%####(%%%%###%%%###%%%%%#/((%%%%#%%%%%%%%%####%%##%%#######%%%%%%%%%%%%%%%%%%%########%%%%%%%%%%%%%%%%%%%###%
(((((((#%%#%####(###(#%%%%%%%%%%%%##/(#(((((((((((##%%%%%%%(/((%%%%%%%%%%%%%%/%%##%%%%%%%%%%%%##%%%%%%%%%%%%%%%%%%%%%%##
((((((#((#(#(##(((((#%%%%%%%%%%%%%%#/(///(/(((///(((##/%%%%%%%#(((((#((((((((((((((%(##%%%%%##(##%%%%%%%%%%%%%%%%%%%%%%#
####(#####(#(##(#(##%%%%%%%%%%%%%%%##(#(#((((((((/((((((////(((#((((///////(((/((((((((((((//(%#(%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%##%#####(#####%%%%%%%%%%%#%##((((((((((((///(/(//////(((##(#((#((((((((/(((/#%#((##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(((((((#(#(##(#((((((((//(/(/(/(//((((((/((((((#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%#";
        string _42 = @"
***********************************,,,,,,,,,*,,,,,,,,,****,,**,,,,,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************
**********************,,,****,,,,,**,,,*,,,,,,,,,,,,,...,,,,,.....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********
***************,********,,*****,,,,,,,,,,,,,,,,,,,,,,..,,,,,...,..,,,,,......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
##/*,*,*,,,,,,**,,****,,,,,..,...,,,,,,****,*,,,..,,,,,,,,,,,,,,,,............,.,,,,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,
##########/.,,,,,,,,,,,....,,,........,,...,,,,,,,,,,,,,,......,,,...........................................,,,,,,,,,,,
##########%%%%%%%%%*,.....,.........................................................................................,,,,
#########%%%%%%%%%%%%%%%%*..........  ..................................................................................
#######%%%%%%%%%%%%%%%%%%%%%%%..........................................................................................
%%######%%%%%%%%%%%%%%%%%%&&%%%%%&%%#*..................................................................................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%%%%%%%%%%/.  . .        ..                 .,###%###/*.................................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%#((%%%%%%%%#((((((((((/*.            ./%%%%%%%%%###(/...............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&%%(%%%%%%%%%%%(((((((((((((//,    .#%%%%%%%%####((/,.............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&#*(%%%%%%%%%%%%%#############((/,%%%%%%%%%###((((/*.... .. ....................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%%#*/%%&%%%%%%%%%%%%%%%%%###########%%%%%%%%###((((///*. ..........,,,,..    ....
%%%%%%%%%%%%%%%%%%%%%%%%%%##&&&&&&&&%%%%#.#%%%%&&%%%&&&&&&&%##############(#%%%%%#######(((((////*****,,,.,*************
##%%%%############%%%%%#%%%%&&&&&&&&%%%/,*#%(((####%%&&%%&%%%%%%%%####((###%%((###########(((((((////////*,*////////////
#####%%%%%%##%%%%%%%%%%%%%%&&&&&&%%#(//(((######((#&%%%&%%&&&%%%%%%%%%%##((*(***#%%%########(((((((((((((((/,,((((((((((
###%%%%%%%%##%%%%%%%%%%%%%&&&&%%%%%##(**%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#,,*/%%%%%##########((((((((((((((((*((((####
%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%#%%#((%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(*/%%%%%%%%%#########################/######
#%%%%%%%%%%%%%%%%%%%%%%%%%%(((##((##%##%%##(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%########################(####
%%%%##%%%%%%%%%%%%%%%#%#%%%((((((%%####%%%%%%%%#(#%%%%%%%%##%%%%%%%%%%%%%%(%%%%%%%%(%#%%%%%%%%%############%%%%%%%###/%%
%%##%%%#%%#%##%##%%#####%%%%%%%%%%###*(%%%%#%%#%%%%%%########%%########%%%%%%%%%%%%%%%%%%###%####%%%%%%%%%%%%%%%%%%%%#(%
(((((((####%####((((##%%%%%%%%%%%%%##/(((/((((((((#((#%%%%%%%%#%#%%%%%%%%%%%%%%###%%%%%%%%%%%%#(%%%%%%%%%%%%%%%%%%%%%%#(
((((#(((#######((((((%%%%%%%%%%%%%%%#///((/(((///((((##((##%%%#((((((((((((((((((((####%%%%%####(#%%%%%%%%%%%%%%%%%%%%%#
##(#########(##(####%%%%%%%%%%%%%%%%%(#(((((((((((((((((////(((#((#((//////////((((((((((((/*(%%#%%%%%%%%%%%%%%%%%%%%%%%
%#%%%%%%%###########%%%%%%%%%%%%%%##/((((((((/(/(///(//(///(/(((##((#(/((((((/(((/*(///##%%%##%%%%%%%%%%%%%%%%%%%%%%%%%%
%%&#%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%(((((##(####(#(#(((##((((((/(/(/(((((((/(/((((/#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#";
        string _43 = @"
***********************************,,,,,,,,,*,**,,,,,*****,,**,,,,,,**,,,,,*,*******************************************
**********************,,,****,,,,**********,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********
************************,,*****,,,,*,,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
##/***,,,,******,*****,,,,,..,,..,,,,,*****,*,,,.,,,,,,,,,,,,,,,,,,,......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
##########/,,,,,,,,,,,,....,,,,.......,,...,,,,,,,,,,,,,,.....,,,,.........................................,,,,,,,,,,,,,
########%%%%%%%%%%%,,.....,.......................................................................................,,,,,,
########%%%%%%%%%%%%%%%%%,..............................................................................................
#######%%%%%%%%%%%%%%%%%%%%%%/..........................................................................................
%%######%%%%%%%%%%%%%%%%&&&&%%%%%%%%/,..................................................................................
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%%/.      ..   ......................#%%%%%%%##/,...............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%/(%%%%%%%#((((((((((/*.            .*%%%%%%%%%%###(*..............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%/#%%%%%%%%#(((((((((((((//,  . .*%%%%%%%%####(((/.............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#&&&&&&&&&&&%#,%%%%%%%%%%%%%############((((*#%%%%%%%%###((((//*...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%#&&&&&&&&&&%%%//(%&%%%%%%%%%%%%%%%%%##########(%%%%%%%%###((((///**,..........,,,...........
%%%%%%%%%%%%%%%%%%%%%%%%%%%#%&&&&&&&&%%%%#/(%%%&%%%%&&&&&%%%######%%#####(#(%%%%%#######(((((/////*****,,..,***********/
###%%%###########%%%%%#%%%%%&&&&&&&&&%%#/,/#(((#(#%&&&%%&%%%%%%%%%#%##((##(/%***##########(((((((/////////**////////////
#%###%%%%%%%%%%%%%%%%%%%%%%&&&&&&%###(/**#%#####((#&%%%%%&&&&%%%%%%%%%%####(/(/**#%%########((((((((((((((((/,/(((((((((
###%%%%%%%%###%%%%%%%%%%#%&&&&&%%%%%##(*#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%/.*/#%%%%##########(((((((((((((##((((######
%%%%%%%%%%%%%%%%%%%%%%%%%%&&#%%%%%%%%%%##/%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%/,(%%%%%%%%##########################/#####
#%%%%%%%%%%%%%%%%%%%%%%%%#%##((##(##%%##%%%##(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#########################/###
%%%%##%%%%%%#%%%%%%%%%%%#%%#(((((#%%##*%%%%%%%%%%%(#%%%%%###%%%%%%%%%%%%%%%%#%%%%%%%(%#%%%%%%%%##########%%%%%%%%%%%###%
%%##%%#%%%%%%####%%######%%%%%%%%%%###(%%%%%%%%%%%%%%%%%%##/#%%###%%%(#%%%%%%%%%%%#%%%%%%########%%%%%%%%%%%%%%%%%%%%%#(
(((((((%###%###((((####%%%%%%%%%%%%%##/(((((((((((((##(%%%%%%%%%#%%%%%%%%%%%%%%%/#%%%%%%%%%%%###%%%%%%%%%%%%%%%%%%%%%%%#
(((((#((##(##(#((((((#%%%%%%%%%%%%%%%#//(((((///(/(/(/%%(((#%%%#(((((((/((((((((((#####%%%%####%#(%%%%%%%%%%%%%%%%%%%%%%
##(##################%%%%%%%%%%%%%%%%#(((((((/((((((((((///((((#((((((///////(/(((((((((((((//%#%%%%%%%%%%%%%%%%%%%%%%%%
%%#%%#%%#############%%%%%%%%%%%%%%##(((((((((/((//(/////////((/(((##((((((((((((#((/*//(*//##%%%%%%%%%%%%%%%%%%%%%%%%%%
%%#%%%%%%#%%%%%%#%%%%%%%%%%%%%%%%%%%#((######(((##((((((/(/((//(/(/(((((((/((((((/#%%%%%%%%%%%%%%%%%%%%%%&&%%&&%%%%%%%%#";
        string _44 = @"
***********************************,,,,,,,,*,,**,,,,,*****,,**,,,,,,**,,,,,*,*******************************************
**********************,,,****,,,,**********,,,,,.,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********
************************,,*****,,,,*,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
##/***,*,*******,*****,,,,,..,,.,,,,,,*****,*,,,.,,,,,,,,,,,,,,,,.,,......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
##########*,,,,,,,,,,,,....,,,,.......,,...,,,,,,,,,,,,,,.....,,,,.........................................,,,,,,,,,,,,,
########%%%%%%%%%%%,......,.......................................................................................,,,,,,
########%%%%%%%%%%%%%%%%#...............................................................................................
#######%%%%%%%%%%%%%%%%%%%%%%,..........................................................................................
%%######%%%%%%%%%%%%%%%%&&&%%%%%%%%%*...................................................................................
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%%%%%%%%%%%*. . .. ..........................,%%%%%%%%###*...............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%((%%%%%%%#((((((((((/,.            .,#%%%%%%%%####((..............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%/(%%%%%%%%#(((((((((((((/*,  . .,#%%%%%%%####(((/,............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#&&&&&&&&&&&&%,(%%%%%%%%%%%%############(#((*#%%%%%%%%###(((///*...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%#&&&&&&&&&&%%%//(%&%%%%%%%%%%%%%%#%%##########(#%%%%%%%###((((////*,..........,,,.. ........
%%%%%%%%%%%%%%%%%%%%%%%%%%%#%&&&&&&&&%%%%%((#%%%%%%%&&&&&&%%#%####%%#####(((%%%#########(((((/////*****,,..,***********/
###%%%###########%%%%%#%%%%%&&&&&&&&&%%#/*/#(((((#%%&&%%&%%%&%%%%%#%##((##(/%***(#########(((((((/////////**////////////
#%###%%%%%%%%%%%%%%%%%%%%%%&&&&&&%%##(/**#######((%&%%%%%&&&%%%%%%%%%%%###%(//(/*(##########((((((((((((((((/,/(((((((((
###%%%%%%%%###%%%%%%%%%%#%&&&&&%%%%%%#(*(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(,**(#%%%##########((((((((((((((##(/(######
%%%%%%%%%%%%%%%%%%%%%%%%%%&&#%%%%%%%%%%##(#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(,*#%%%%%%%##########################/#####
#%%%%%%%%%%%%%%%%%%%%%%%%#%##((##(##%%##%%%##(#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#########################/###
%%%%##%%%%%%#%%%%%%%#%%%#%%#(((((#%%##/#%%%%%%%%%%(##%%%%##%%%%%%%%%%%%%%%%%%%%%%%%%###%%%%%%%###########%%%%%%%%%%%##(%
%%##%%#%%%%%%####%%######%%%%%%%%%%###(##%#%%%%%%%%%%%%%%##(#%%####%%/(%%%%%%%%%%%##%%%%%########%%%%%%%%%%%%%%%%%%%%%#(
(((((((%#######(((#(###%%%%%%%%%%%%%%#/((((((((((((((#(%%%%%%%%%%%%%%%%%%%%%%%%%(#%%%%%%%%%%%###%%#%%%%%%%%%%%%%%%%%%%%#
(((((#((##(##((((((((#%%%%%%%%%%%%%%%#////(((///(/(/((#%(((##%%#(((((((/((((((((((#(###%%%%####%#(%%%%%%%%%%%%%%%%%%%%%%
##(##################%%%%%%%%%%%%%%%%#(((((((/((/(((((((///(((#(((((/////////(/(((((((((((((//##%%%%%%%%%%%%%%%%%%%%%%%%
%%#%%#%%#############%%%%%%%%%%%%%%%%(((((((((/((//(/(/////(((#(((/##(((((((((((((((/////*/*(%%%%%%%%%%%%%%%%%%%%%%%%%%%
%&#%%%%%%#%%%%%%##%%%%%%%%%%%%%%%%%%#(((#####(((##((((((//(((////(/(((((((/((((((/##%%%%%%%%%%%%%%%%%%%%%&&%%&&%%%%%%%%#";
        string _45 = @"
***********************************,,,,,,,,*,,***,,,,****,,,*,,,,,,,**,,,,,*,*******************************************
**********************,,*****,,,,**********,,,,,.*,,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********
************************,,*****,,,,,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
##/*****,*******,*****,,,,,..,,.,,,,,********,,,.,,,,,,,,,,,,,,,,.,,......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
##########,,,,,,,,,,,,,....,,,,.......,,..,,,,,,,,,,,,,,.....,,,,,.........................................,,,,,,,,,,,,,
########%%%%%%%%%%#,..............................................................................................,,,,,,
########%%%%%%%%%%%%%%%%(...............................................................................................
#######%%%%%%%%%%%%%%%%%%%%%%...........................................................................................
%%#####%%%%%%%%%%%%%%%%%&&&%%%%%%%%%*............................................,,*,,..................................
%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%%#.. .. ............................(%%%%%%%%###(/..............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%*(%%%%%%#((((((((((/,.            ../%%%%%%%%####((/.............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&#/%%%%%%%%#((((((((((((//*.  .  .(%%%%%%%####(((//............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%(*#%%%%%%%%%%%############((((/(%%%%%%%####(((///**..........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%#&&&&&&&&&&&%%%*/#%%%%%%%%%%%%%###%###########/##%%%%%####((((/////*,,.......,,,,...........
%%%%%%%%%%%%%%%%%%%%%#%%%%%#%&&&&&&&&&%%%%%/#%%%%%%&&&&&&&%######%%#######((#%#########((((((////*******,,.,,,********//
###%%%###########%%%%%%%%%#%%&&&&&&&&%%%(*,(((##(#%%&&&%&%%%%%%#%##%#((####*(,,,*(#######((((((////////////*////////////
#%##%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%%#%/*//(####((#%%%%%%%&&&%%%%%%%%%%####%##,/(*(#########(((((((/((((((((((*/(((((((((
#%%#%%%%%%%###%%%%%%%%%%%%&&&&&&%%%%%##/*%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#*,*(%%%###########(((((((((((#####/(######
##%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%%%%##(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#*./%%%%%%############################(####
####%%%%%%%%%%%%%%%%%%%%%%#%#########%##%%%%%#(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%##########################(##
%%%##%%%%%%%%%%%%%%%#%%%#%%%((((((#%%##(%%%%%%%%%%%#(%%%%##%%%%%%%%%%%%%%%%%%##%%%%%%###%%%%%%###########%%%%%%%%%%%##(%
%##%%#%%%#%##%#(%%########%%%%#%%%%%##((#%(%%%%%%%%%%%%%%%##(#####%%#(((#%%%%%%%%%%##%%%%########%%%%%%%%%%%%%%%%%%%%%#(
((((((####%####(((((#####%%%%%%%%%%%%#/(/((((((((((((#(##%%%%%%%%%%%%%%%%%%%%%%%%##%%%%%%%%%%###%%#%%%%%%%%%%%%%%%%%%%%#
(((#(((#######(((((((#%%%%%%%%%%%%%%%#(///(((///((//(((#%((##%%#((((((((((((((((((####%%#%#####%%(#%%%%%%%%%%%%%%%%%%%%%
######################%%%%%%%%%%%%%%%#((((((((((/(/(/((////(((#((#(((/////////(((/(((((((((((((/%%%%%%%%%%%%%%%%%%%%%%%%
#%%%%%%%##############%%%%%%%%%%%%%%%(((((((((/(/////(//////(((((((#((((((((/(((((((////****(#%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%##%%%%%%%%%%%#%%#%%%%%%%%%%%%%%%%/((((###((#(((#((((/((((///(/(((((((//(((((//##%%%%%%%%%%%%%%%%%%%%&&&%%&&%%%%%%%%#";
        string _46 = @"
**********************************,,,,,,,,**,,*,,,,,*****,,**,,,,,,,*,,,,,,,,*******************************************
**********************,,****,,,,***********,,,,.,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
***********************,,*****,,,,*,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
##/,************,****,,,,,..,,..,,,,,*****,**,,.,,,,,,,,,,,,,,,,,,,.......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
##########,,,,,,,,,,,,,....,,,.......,,,..,,,,,,,,,,,.,,.....,,,,,.........................................,,,,,,,,,,,,,
#######%#%%%%%%%%%*,..............................................................................................,,,,,,
########%%%%%%%%%%%%%%%%*...............................................................................................
#######%%%%%%%%%%%%%%%%%%%%%#...........................................................................................
%%#####%%%%%%%%%%%%%%%%%%&%%%%%%%%%(*...........................................*//(#((,................................
%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%%%%%%%%%%%(. ...............              ..,#%%%%%%%####((..............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%#%%%%%/(%%%%%#((((((((((/*.             ..*%%%%%%%####(((/*............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&/#%%%%%%%(((((((((((((//,  .   ./%%%%%#####((((//*...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##&&&&&&&&&&&%#.(%%%%%%%%%%##############((/*#%%%%%%%###(((///***,.........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%&&&&&&&&&&%%%///%%%%%%%%%%%%%##%%###########/(#%%%%%###((((///****,,.......,..............
%%%%%%%%%%##%%%%%%%%#####%%(%&&&&&&&&&%%%%%/##&&&%%&&&&&%%%######%%########(#%########(((((//////*******,,..,,**********
##%%%%##########%%%%%#%%%%#%%&&&&&&&&%%%%**/(((###%&&%%%%%%%%%%%%####((####/*/,,*/#####(((((((//////////////*///////////
####%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%%%#(//*(####((#&%%%%%%&&%%%%%%%%%%%###%%##*,(/(########((((((((((((((((((((*(((((((((
##%#%%%%%%%######%%%%%%%%%%&&&&&&%%%%##(*#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(*,*/#############((((((((((((#####((######
#####%%%%%%%%%#%%%%%%%%%%%%&%#%%%%%%%%####/%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#**,%%%%###########(##################/####
#####%%%%%%%%%%%%%%%%%%%%%%%############%%%%%#(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(%%%%%%%%#%%##########################(##
%%###%%%%%%#%%%#%%%#%%%###%%#(((((#%%##/%%%%%%%%%%%#(#%%###%%%%%%%%%%%%%%%%%%#(%%%%%%%###%###############%%%%%%%%%%%##(%
%##%##%%#%%%####%%##############%%%%###(##%%%%%%%%%%%%%%%%###/####%%(((((%%%%%%%%%%%(%%##########%%%%%%%%%%%%%%%%%%%%%##
((((((#######(((((((#(#%###%%%%%%%%%%##(((((((((((((#(###%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%###%%#%%%%%%%%%%%%%%%%%%%%#
((((#((#((##((((((((((%%%%%%%%%%%%%%%##//(((///(/(/(((((#####%%#((((((/(((((((((((####%%%%%######/#%%%%%%%%%%%%%%%%%%%%%
#############(##(#####%%%%%%%%%%%%%%%##(((((/((((((((((///((((#((#(/(/////////(/(((((((((((((#((%%%%%%%%%%%%%%%%%%%%%%%%
%#%%%%%#############(#%%%%%%%%%%%%%%%#(((((((/((//(/(///////((/((/#(((((((((((((((#(/////**((#%%%%%%%%%%%%%%%%%%%%%%%%%%
%#%##%%%%%%%%%%##%%%%#%%%%%%%%%%%%%%%/(((###((((#((((((//(((//////(((((((/((((((//##%%%%%%%%%%%%%%%%%%%%&&&%%%%%%%%%%%%#";
        string _47 = @"
**********************************,,,,,,,,**,,*,,,,,,****,,,,,,,,,,,*,,,,,,*,*******************************************
**********************,,*****,,,***********,,,,.,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********
***********************,,*****,,,,*,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
##(*****,*******,****,,,,,..,,..,,,,,*****,**,,.,,,,,,,,,,,,,,,,,,,.......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
##########,,,,,,,,,,,,,.....,,.......,,,..,,,,,,,,,,,.,,.....,,,,,.........................................,,,,,,,,,,,,,
#########%%%%%%%%%/,..............................................................................................,,,,,,
#########%%%%%%%%%%%%%%%*...............................................................................................
########%%%%%%%%%%%%%%%%%%%%(...........................................................................................
%%#####%%%%%%%%%%%%%%%%%%&%%%%%%&%%#*..........................................,/((####,................................
%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%%%%%%%%%%%(. . .............              ..,#%%%%%%%####((,.............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%#%%%%%/(%%%%%#((((((((((/*.             ../%%%%%%%####(((/*............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%/#%%%%%%%(((((((((((((//,  .   ./%%%%%#####((((//*...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##&&&&&&&&&&&%#.(%%%%%%%%%%##############((/*/(%%%%%####(((///***,.........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%&&&&&&&&&&%%%(//%%%%%%%%%%%%%##%%###########/(#%%%%%###((((////***,,,,.,...,..............
%%%%%%%%%%##%%%#%%%%#####%%(%&&&&&&&&&%%%%%/##&%&%%&&&&&%%%#%####%%########(##########(((((//////*******,,..,,********//
##%%%%##########%%%%%#%%%%#%%&&&&&&&&%%%%**/(((##%%&&%%%%%%%%%%%%####((####(*(,,,*#####((((((((/////////////*///////////
#####%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%%%##//*(####(#%%%%%%%%&&%%%%%%%%%%%###%%%#*.//(#########(((((((((((((((((((*(((((((((
####%%%%%%%######%%%%%%%%%%&&&&&&%%%%##(*#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(,,*/#############((((((((((((#####((######
#####%%%%%%%%%#%%%%%%%%%%%%&%%%%%%%%%%####/%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#*/,%%%%##########(###################/####
#####%%%%%%%%%%%%%%%%%%%%%%%############%%%%%((%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%##########################(##
%%###%%%%%%#%%%%%%%#%%%%##%%#((((((%%##(%%%%%%%%%%##(#%%###%%%%%%%%%%%%%%%%%%#(%%%%%%%####%##############%%%%%%%%%%%%#(%
###%##%%#%%%####%%##############%%%%###/##%%%%%%%%%%%%%%%%###/####%%((#(((%%%%%%%%%%(#%#########(%%%%%%%%%%%%%%%%%%%%%##
((((((######((((((((#(#%###%%%%%%%%%%#(/((((((((((((((#(#%%%%%%%%%%%%%%%%%%%%%%%%%%(%%%%%%%%###(%##%%%%%%%%%%%%%%%%%%%%#
((((#((#((##((((((((((%%%%%%%%%%%%%%%##//(((///(/(/(((((#####%%(((((((/((((((((((#####%%%%%###(((*#%%%%%%%%%%%%%%%%%%%%%
################(#####%%%%%%%%%%%%%%%#((((((/((((((((((///(((##((((///////////(/(((((((((((((#((%%%%%%%%%%%%%%%%%%%%%%%%
%#%%#%%#############(#%%%%%%%%%%%%%%%#(((((((/((//(/(//////((((((/#(//((((((((((((#//////*//(%%%%%%%%%%%%%%%%%%%%%%%%%%%
%#%%#%%%#%%%%%%##%%#%#%%%%%%%%%%%%%%%/((####((((#((((((//(((/////((((((((/((((((//(#%%%%%%%%%%%%%%%%%%%%&&&%%%%%%%%%%%%#";
        string _48 = @"
**********************************,,,,,,,,,,*/*,,,,,**,*,,,,,,,,,,,,,,,,,,,*,*******************************************
*****************************,,,*******,,*,,,,,,,,,...,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********
*****************,****,,,*****,,**,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
##(**,,*****,,,,,,,,,,,,,,..,,..,,,,,********,..,,,,,,,,,,,,,,,,,,........,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
#########/,,,,,,,,,,,,..............,,,,..,,,,,,,,,,........,,,,,..........................................,,,,,,,,,,,,,
#########%%%%%%%%%,...............................................................................................,,,,,,
#########%%%%%%%%%%%%%%*................................................................................................
########%%%%%%%%%%%%%%%%%%%%,...........................................................................................
%######%%%%%%%%%%%%%%%%%%%%%%%%%%%%*.........................................,#%%%%%%###/...............................
%%%%%%%#%%%%%%%%%%%%%%%%%%&&&%%%%%%%%%%%%*   ..............   ....       ..,%%%%%%%%###(((/.............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(/%%%%%(((((((((((/*.             ../%%%%%%%####((//*............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&#/%%%%%%((((((((((((((//.      .#%%%%%####(((///**...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%#&&&&&&&&&&&&%(,%%%%%%%%%###############(((*,*%%%%%###((((//***,,.........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#&&&&&&&&&&&%%%///%%%%%%%%%%#################/(#%%%%###(((((///***,,,,,,,,,,,,.............
%%%##%%%%#####%##%%%#####%#(#%&&&&&&&&&%%%#%/(%%%%&&&&&&%%#######%#########(##//(####((((((/////********//,..,*******///
##%%%#######%%#%%%%%%%%%%#%#%&&&&&&&&&%%%#**((((%%&%%%%%%%&&%%%%#%##((######/*#//*/###((((((((//////////////*/////////((
#####%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%%//*//#((#%%%&%%%%&&%%%%%%%%%%%###%%%##(.,/(########(((((((((((((((((((((*((((((((
####%%%%%%%#######%%%%%%%#%&&&&&&&&%%%##//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#,,(##############((((((((((########(######
######%%%%%%%%%%%%%%%%%%%%%&&&%#%%%%%%%%##/(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%/#/#%%%###############################(###
#####%%%%%%%%%%%%%%%%%%%%%%%%########(#%#####*%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%(%%%%%%%#########################%%##(##
%##%%%%%%%%%%#%%%%#%%%##%%#%%((((((#%##(*%%%%%%%%##/#%%###%%%%%%%%%%%%%%%%%%%%(#%%%%%%%(####(((###%%##%%%%%%%%%%%%%%%###
#%%#%%%#%%%%###%%###%#########((((#%%##((%##%%%%%%%%%%%%%#####/(#%%(((%#/#/%%%%%%%%%%%##########/%%%%%%%%%%%%%%%%%%%%%%#
(((((######((((((((((((##%%%%%%%%%%%%%#*(((((((((((#(#((#%%%%%%%%%%%%%%%%%%%%%%%%%%%(%%%%%%###%(%###%%%%%%%%%%%%%%%%%%%%
((##########(((((((((/%%%%%%%%%%%%%%%%##(((///(/////((((((((%%%((((((/((((((((((((#(###%%#####((/##%%%%%%%%%%%%%%%%%%%%%
############(##(#(####%%%%%%%%%%%%%%%%(/(((((((((((((//(((((#(##(#(/////////((//((((((((((((/(#%%%%%%%%%%%%%%%%%%%%%%%%%
%%#%%#################%%%%%%%%%%%%%%%##(((((//////////////((#(/(/(((((((((((((((((//////,*,*#%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%#%%%%%%%%%%#%%%%(###%%%%%%%%%%%%%%%%(###(((#((((((((//((//*/(//((((((((/(((((//(#((##%%%%%%%%%%%%%%%%%&&&%%&&%%%%%%%%#";
        string _49 = @"
**********************************,,,,,,,,,,*/*,,,,,**,*,,,,,,,,,,,*,,,,,***,************,,,,***************************
****************************,,,********,,*,,,,,,,,....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********
*****************,****,,,*****,,*,,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**
##/**,,****,,,,,,,,,,,,,,,.,,,..,,,,,*******,,..,,,,,,,,,,,,,,,.,,........,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
#########*,,,,,,,,,,,.....,.........,,,..,,,,,,,,,,,........,,,,...........................................,,,,,,,,,,,,,
#########%%%%%%%%#................................................................................................,,,,,,
#########%%%%%%%%%%%%%%,................................................................................................
########%%%%%%%%%%%%%%%%%%%(............................................................................................
%#####%%%%%%%%%%%%%%%%%%%%%%%%%%%%%,........................................./%%%%%%%###(,..............................
%%%%%%%#%%%%%%%%%%%%%%%%%%&&&%%%%%%%%%%%%, .  ...........       ..  ...  ..,#%%%%%%%###(((/.............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(/#%%%%(((((((((((/,.             ../%%%%%%%###(((//*............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%/%%%%%%(((((((((((((//*. .    .#%%%%%####(((///**...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%#%&&&&&&&&&&&&#,#%%%%%%%%###############((/*,*%%%%%###(((///***,,.........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%&&&&&&&&&&&%%(**%%%%%%%%%%#################/###%%###(((((/////**,,,,,,,,*,,,.............
%%%##%%%########%%%#########(%&&&&&&&&&%%%#%/(#%%%&&&&&&%%#######%#########(/#**(####((((((/////********//,,.*******////
##%%%#######%%#%%%%%%%%%##%#%&&&&&&&&&%%%%/*/(((%%&%%%%%%%&%%%%%#%##((######(*/((*/#####((((((///////////((/*////////(((
#####%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%%%/*///((((%%%%%%%%&&%%%%%%%%%%%###%%%##(../(########(((((((((((((((((((((*/(((((((
####%%%%%%%#######%##%%%%#%&&&&&&&&%%%##/*#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#,,(##############(((((((((#########((#####
#####%%%%%%%%%%%%%%%%%%%##%&&&%#%%%%%%####((%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%/#/##%%###############################(###
#####%%%%%%%%%%%%%%%%%%%%%%%%############%###*%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%/#%%%%%%#########################%%##(##
%##%%%%%%%%%%#%%%%#%%%##%%#%%((((((####(*##%%%%%%##(#%%###%%%%%%%%%%%%%%%%%%%%(#%%%%%%%#####((####%%##%%%%%%%%%%%%%%%%##
#%%#%%%#%%#%###%####%###(#####((((##%##((%##%%%%%%%%%%%%%#####/#(#%(/(##(#(#%%%%%%%%%%##########/%%%%%%%%%%%%%%%%%%%%%%#
(((((######(((((((((((((##%%%%%%%%%%%%#//((((((#(((((#((%%%%%%%%%%#%%%%%%%%%%%%%%%%%(#%%%%%###%(%###%%%%%%%%%%%%%%%%%%%%
((#####(####((((((((((#%%%%%%%%%%%%%%%##/((///(/////((((/(/(%%%#(((((/((((((((((((((##%%%%##%#(#*##%%%%%%%%%%%%%%%%%%%%%
(##############(#(####%%%%%%%%%%%%%%%%(/(((((((((((((//(((((#(##(#(/////////((//(((/((((((((/(#%%%%%%%%%%%%%%%%%%%%%%%%%
#%#%%#################%%%%%%%%%%%%%%%##(((/(//////////////((#(/(/((((((((((((/((((/////*****#%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%#%%%%%%%%%%#%%%%####%%%%%%%%%%%%%%%#(###(((#(((((((//((((/*/(//((((((((((((((//((((##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#";
        string _5 = @"
*****************************////////////////////////(((((((((((((((((##########################################%%%%%%%%
,,,**,,****************************////////////////////////////(((((((((((((((((((((((##################################
,,,,,,,,,,,,,,,,,,,,*************************************//////////////((//((((((((((((((((((((((((((((#################
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**********************************///////////////////////(((((((((((((((((((((((((((((((((
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************///////////////////////////////((((((((((((((((((((
.........,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************************//////////////////////////////(((((((((
...........................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************/////////////////////////////
.......................................,,,,,,,,,,,,*%%/,,,,,,,,,,,,*******************************//////////////////////
#####(,......................................,,,,%&&&&&&&(,,,,,,,,,,,,,,,,,,*********************************///////////
##############/................................*%&&&&&&&&&%,,,,,,,,,,,,,,,,,,,,,************************************////
#######%%%%%%%%%%%%%%%%%%%(...................##%&&&&&&&&(,,,,,,,,,,,,,,,,,,,,,,,,**************************************
%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%(,.........,//%&&&&&&&&,..,,,,,,,,,,,,,,,,,,,,,,,,,,,**********************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%////&&&&&&&&&&....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************
##%%%%%%%########%%%%%%%%%%&&&%%%%%%%%%%%/(*#&&&&&&&&&&&&%%%%%%#*,,,,,,,,,,,,,,,*****,**********************************
##########%##%%%#%%%##########%%%%%%###%%**(%&&&&&&&&&&%##%#%%&&&&&&&&&&&&&&%%###((/****,,******************************
###############################%%%%%%%%%%**#&&&&&&&&&&&&###%%%%%%&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%#/**////******
#####%%%#%%#%%###########################**%&&&&&&&&&&&&%%%%&&%%%%####%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%/
##%%%%%#################################,*#%&&&&&&&&&&&&#((&&&@&%####%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%####%%%%%%%#############%%%%%%%%##,*#&&&&&&&&&&&&&&#((&&&&&&%#######%#################%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%##%%%%%%%**/%&&&&&&&&&&&&&&&*/#&&&&&&&&&%%%%%%#%%%%#############%######%%%%%%%%%%%%%%%%%%%%%
##%######%%#%###%########%###%%%%%%%*/(%&&&&&&&&&&&&&&&&(*##&&&&&&&&&&&&&%%&%%%&%#%%%%%%%%&&&&&&%###########%%%%%%%%%%%%
(((((((((((((((((((((((/((((((((((((*(%&&&&&&&&&&&&&&#&&&&&%%%&&&&&&&%%%&%%%%%&&&%%%%%%%%%&&&%#%%%%#%%%%%###%##%%%%%%##%
#######(###%####(#######%####(#((((#(/&&&&&&&&&&&&&&&%%%((%%%%%&&&&#((((((##(###(####((##((((((#(#(#########(((#########
#####################%############%%#(%&&&&&&&&&&&&&&&%##%%#%%%%%%%%(#(#########((###(####%%%############%%#%%%%%%%%%%%%
%%%%%%%%%###########((##############%(%&&&&&&&&&&&&&&&#####%%%%%%%%%%####(####(##%%%%%%#####%###%######################%
&%%%%&&%%%%%%%%#######%#(###########&#%&&&&&&&&&&&&&&&%(##%%%%%%%%%%%###%#%%%%%%%%%#%%%%%%%#%##%%%###%%##%%#####%####%%%
&&&&&&&&&&&&&&%%%%##%%%&&%%%%######/&(&&&&&&&&&&&&&&&&&####/%%%%%%%%%%%&%%%%#%%%%%#%%%%%%%%%%%%%%%%%#%###%%%%%%%%%%%%%##";
        string _50 = @"
*********************************,,,,,,,,*,*//*,,,,**,*,,,,,,,,,,,,*,,,***************,,,,,,,***************************
***************,************,,,********,,,,,,,,,,....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********
*****************,***,,,,****,,,*,,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**
#/***,,,,,*,,,,,,,,,,,,,,..,,..,,,,,*******,,,..,,,,,,,,,,,,,,,.,,........,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
#######%(,,,,,,,,,,,,.....,.........,,,..,,,,,,,,,,,........,,,,...........................................,,,,,,,,,,,,,
#########%%%%%%%%*..............................................................................................,,,,,,,,
#########%%%%%%%%%%%%%#.................................................................................................
########%%%%%%%%%%%%%%%%%%%*.....................................................,,**,..................................
%#####%%%%%%%%%%%%%%%%%%%%%%%%%%%%#,........................................*%%%%%%%%####(..............................
%%%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%%%%#... ...........                 ..,#%%%%%%####((//*............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##(((#%%%%((((((((((//,.              .*%%%%%#####(((//*,...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&%%/#%%%%#(((((((((((((//*.      ,#%%%%%####(((//**,,..........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%###%&&&&&&&&&&&%/*%%%%%%%%###############((//*/#%%%%###(((///**,,,.........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%&&&&&&&&&&&%%**(%%%%%%%%%%#################((%%####(((((////****,,,,*,,,,,,.............
%%%##%%%########%%%######%##(%&&&&&&&&&&%%%%%(/%%%&&&&&&%#(######%########((*#,,*(###((((((////*****/**///*,,*******////
#%%%########%##%%%%%%%%%#%%%#%&&&&&&&&&%%%%**/((%&&%%%%%%%&%%#%%%%%#(########/*/#,/(###(((((((///////////(((/**/////((((
####%%%%%%%%%%%%%%%%%%%%%%#%%%&&&&&&%&%#(//*/(((%%%%%%%&&&%%%%%%%%%%%####%###(*,/(#########(((((((((((((((((((((/(((((((
###%%%%%%%######%#%%%%%%%##%&&&&&&&&%%%#/,/(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#*,/#(############(((((((############/(####
###%#%%%%%%%%%%%%%%%%%%%#(%%&&&%%%%%%%%###(/%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%/##%#%%###############################((##
#%###%%%%%%%%%%%%%%%%%%%%%%%&%##%%%%%%#######*%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%##%%%%%%%#####################%#%%%%##(%
###%%%%%%#%%%#%%%#%%%%#%%%%#%#((((((####(/#%%%%%##/#%%%##%%%%%%%%%%%%%%%%%%%%%%(#%%%%%%############%%%%%%%%%%%%%%%%%%%#(
#%##%##%%%#####%#####%#((###%#(((((##%##((%%%##%%%%%%%##((####(####(/((((#%#%%%%%%%%%%##########(%%%%%%%%%%%%%%%%%%%%%%#
((((####%##((((((((((((((##%%%%%%%%%%%%#/(/((((((#((((#%%%%%%%%%%%####%%%%%%%%%%%%%%%(#%%%%%#%%#%(%#%%%%%%%%%%%%%%%%%%%%
#(#((#((##(#(((((((((/(##%%%%%%%%%%%%%%#///////(///(((((////#%%%%#((((((((((((((((((###%%#####(%(%%%%%%%%%%%%%%%%%%%%%%%
##############(#####((#%%%%%%%%%%%%%%%#(((((/(((/((((//((((######(/////////(////(((/((((((((*/%%%%%%%%%%%%%%%%%%%%%%%%%%
%%#%%###########(#(###%%%%%%%%%%%%%%%%#(/((//(////////////((((/(/(/(((/(/(/((/((((///(*,,**(%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%#%%%#%%%%%%#%%%#%%##%%%%%%%%%%%%%%%%#(##(((#(((((((//((((///(/(((((((/(/((#((//(#((#%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%%%%#";
        string _51 = @"
*********************************,,,,,,,,,,*/*,,,,,**,,,,,,,,,,,,,,,,,,****************,,*******************************
***************************,,,*********,,,,,,,,,,,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************
****************,*****,,*****,,*,,,,,,,,,,,,,,,,,,....,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**
/**********,,,,,,,,,,,,,,.,,,..,,,,,*******,,,..,,,,,,,,,,,,,,.,,........,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
#######(,,,,,,,,,,,,,....,,,,......,,,,.,,,,,,,,,,,........,,,,,..........................................,,,,,,,,,,,,,,
#########%%%%%%%(,..............................................................................................,,,,,,,,
#########%%%%%%%%%%%%%*.................................................................................................
########%%%%%%%%%%%%%%%%%%#.....................................................,/*(#((,................................
######%%%%%%%%%%%%%%%%%%%%%%%%%%%%/........................................./%%%%%%%%####(*.............................
%%%%%##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%* ..............            ...  ...#%%%%%%####((//*............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%###(##%%(((((((((((//.               .,%%%%%#####((///*,...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%/#%%%%((((((((((((((//,       ,%%%%%%####(((//**,...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%#%#%%%&&&&&&&&&&&&#,#%%%%%%###############((//**/(#%%####(((///**,,,.........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%&&&&&&&&&&&&%#/*%%%%%%%%%%################(((%%####(((((////****,,,,,,*,,,,.............
%%%%%%%%###%%%%%%%######%%%%%#%&&&&&&&&&&%%%%//#%&&&&&&&%##%##############((*#*,,/##((((((/////*****/**////*******//////
#%%%###########%%%%#%%%%#%%%(%%&&&&&&&&&%%%%#*((%&&%%%%%#&&%%#%#%###(#########.*#*//###(((((((//////////(((((,*/////((((
###%%%%%%%%%%%%%%%%%%%%%%%%#%%&&&&&&%&&&%##***(#%%%%%%%&&&%%%%%%%%%%####%%####*,*/#########(((((((((((((((((###(/(((((((
#####%%%%%#%#%####%%%%%%%%#%%&&&&&&&&%%(//,/(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%/,,#(############((((((##############(####
###%%%%%%%%##%%%#%%%%%%%%/%%&&&&%%%%%%%###(/%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%(###/#%################################(##
#####%%%%%%%%%%%%%%%%%%%%%%%&&%#%%%%%%%%#####/%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##%%(#%%%%%%%####################%#%%%%##(%
(###%%%%%%%%%%%%%(%%%%#%%%%%##(((((((####/#%%%%##((#%#%##%%%%%%%%%%%%%%%%%%%%%%/##%%%%%%###########%%%%%%%%%%%%%%%%%%%##
####%%#%%%####%#%######(####%#((((((#%%##/%%%##%%%%%%%##(#%%######((/((/(##%#%%%%%%%%%%########%(%%#%%%%%%%%%%%%%%%%%%%#
(((#########((((((#((((((####%####%%%%%##/(((((((#(((#%%%%%%%%%%%###(##%%%%%%%%%%%%%%%(%%%%%#%%#%###%%%%%%%%%%%%%%%%%%%%
((#((#(((#((((((((((///(##%%%%%%%%%%%%%#(//////(/(/((((((//((%%%%%%#(((((((((((((((####%%#####(%(%%%%%%%%%%%%%%%%%%%%%%%
(#####(#(##(##(#(###((#%%%%%%%%%%%%%%%%#(##((((((((((/((((((####((/////////(////(((/((((((((*/#%%%%%%%%%%%%%%%%%%%%%%%%%
%#%%%#############(###%%%%%%%%%%%%%%%%%#/((//(//(///(/////((((((/(//(//(((/((/((((///(*,**/(%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%#%####%%%%%%%%%%%%%%%%#(#((((#((((((/((((//////(((((((/(/(((((//(#((#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%";
        string _52 = @"
********************************,,,,,,,,*,,*/*,,,,****,,,,,,,,,,,,*,,,,****************,,*******************************
********************,,****,,,,**********,,,,,.,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************
*********************,,*****,,*,,,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
************,,,*,,,,,,,,..,,..,,,,,*****,**,,..,,,,,,,,,,,,,,,.,,.......,,,,,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
#######,,,,,,,,,,,,,....,,,,.......,,,..,,,,,,,,,,,........,,,,,..........................................,,,,,,,,,,,,,,
#########%%%%%%#,,..............................................................................................,,,,,,,,
#########%%%%%%%%%%%%#..................................................................................................
########%%%%%%%%%%%%%%%%%%*.....................................................*((###(/,...............................
######%%%%%%%%%%%%%%%%%%%%%%%%%%%(,........................................./%%%%%%%%####(/.............................
%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#................               .....#%%%%%%####((//*............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%######%%(((((((((((/*.               ..%%%%%#####((//**,...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%/##%%%((((((((((((((//,       .#%%%%####((((//**,...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%#%#%%%%&&&&&&&&&&&%*/%%%%%%###############((//////(%%####(((///**,,,.........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%#%&&&&&&&&&&&%%(,/%%%%%%%###################((#%###((((((////****,,,,,,**,,,.............
%%%%%%%%##%%%%%%%%#####%%%%%%%#%&&&&&&&&&%%%%%//%&&&&&&%%#################(((*(,,*(#((((((/////*****/**////***/***//////
%%%###########%%%%%##%%%#%%%%(%&&&&&&&&&%%%%%(/(%&&%%%%%#&%%%#%#%###(#########*./(//###(((((((//////////(((((/,////(((((
###%%%%%%%%%%%%%%%%%%%%%%%%%##%&&&&&&&&&%%##/,/#%%&%%%%&&&%%%%%%%%%%####%%####(,,,########((((((((((((((((((####(*((((((
#####%%%%%###%######%%%%%%%#%%&&&&&&&%%%(#**/(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(,.*((###########((((################(####
#####%%#%%%##%%%#%%%%%%%%%(%&&&&&&%%%%%%###,(%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%(####%%###############################(##
#####%%%%%%%%%%%%%%%%%%%%%#%&&%%#%%%%%%######/%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##%%##%%%%%%#####################%%%%%%%##(
#####%%%%%%%%%%%%#%%%##%%%%%%%####(########%##%%#((###%##%%%%%%%%%%%%%%%%%%%%%%###%%%%%%%##########%%%%%%%%%%%%%%%%%%%%#
%###%%#%#%##(%%###(####(#####%#((((((#%%##(%%##%%%%%%%#((#%%%###%%##((#####%%#%%%%%%%%%%#########%###%%%%%%%%%%%%%%%%%%%
(((#%%#%####((((((((((((((###%##(#(#%%%%##((((((((((##%%%%%%%%%%####(((##%%%%%%%%%%%%%%#%%%%%###((##%%%%%%%%%%%%%%%%%%%%
(((((((((#((((((((((///((##%%%%%%%%%%%%%#/(#(//(///((((((/(((#%%%%%%%%%#(((((((((((#####%##########%%%%%%%%%%%%%%%%%%%%%
(##(#(##(#(#(((#((##((##%%%%%%%%%%%%%%%%##(##((((((((/((((((####((//////////////(((/((((((((//%%%%%%%%%%%%%%%%%%%%%%%%%%
#########(#####(#######%%%%%%%%%%%%%%%%%#((/((////(///////((((((((//(//(((/((/((((///(*,,,(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%##%%%#%####%%%%%%%%%%%%%%%%%#(((((#((((((///(//*////(((((((///(((((/((#((##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%";
        string _53 = @"
********************************,,,,,,,,,,,//*,,,,****,,,,,,,,,,,,*,,,,****************,,**,,***************************
*******************,,*****,,,,*********,,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************
*********************,,*****,,,*,,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
,************,***,,,,,,...,,.,,,,,,********,,.,,,,,,,,,,,,,,,,.,,.......,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
######(,,,,,,,,,,,,,...,,,,,.......,,,..,,,,,,,,,,,.,......,,,,,..........................................,,,,,,,,,,,,,,
#########%%%#%#(,,..............................................................................................,,,,,,,,
#########%%%%%%%%%%%%(..................................................................................................
########%%%%%%%%%%%%%%%%%%...................................................../#%%%%###/...............................
######%%%%%%%%%%%%%%%%%%%%%%%%%%%/........................................../%%%%%%%%###(((.............................
%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(................               .....#%%%%%%####((//*,...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%###%%%#((((((((((//*.               ..#%%%%#####((//**,...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&%#/#%%%((((((((((((((//,        #%%%%#####(((//**,...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%&&&&&&&&&&&#*(%%%%%###############((////*/(######(((///**,,,........,................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%#%&&&&&&&&&&&%%*,#%%%%%%###################((######(((((////****,*,**,***,,.............
%%%%%%%%%%%%%%%%%%####%%%%%%%%%#%&&&&&&&&&%%%%#/(%&&&&&%%#################(((*((*,*((((((((////*//*/////////**//////////
%%############%%%%%##%%%%%%%%%/%&&&&&&&&&%%%%#*(#&&%%%%%#&%%%#%#%%%#(#########(.,*,/###((((((((//////(((((((((/*/(((((((
##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%##*,/%%&%%%%&&&%%%%%%%%%%####%%#####*,,(#(######(((((((((((((((#######(/(((((
#####%%%%%%%%%######%%%%%%%%%%%&&&&&&&%%##(*,//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/,.*(################################/###
#####%%#%#%######%%%%%%%%%%#%&&&&&&%%%%%###/*(%%%%%%%%%%%%%%%%%%%%%%%%%%%##%%%%#/##(##%########################%%%%%##/#
#####%%%%%%%%%%%%%%%%%%%%%(#%&&&%#%%%%%%######*%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%(%%%%%%################%%##%%%%%%%%%##
(####%%%%%%%%%%%%#%%%##%%%%%%#%#((((####(##%%#%###(###%##%%%%%%%%%%%%%%%%%%%%%%#/%%%%%%%%%(###%###(#%%%%%%%%%%%%%%%%%%%#
%###%%#%#%##(%%#%#(##%#(##(#(#%#((((((#%###/%%#%%%%%%%%#((%%%%##%%%#########%%%%%%%%%%%%%####%%%%#%##%%%%%%%%%%%%%%%%%%%
(((%%%%%####(((((((((((((((###%#((((#%%%###/(((((((((#%%%%%%%%%%#####((###%%%%%%%%%%%%%##%%#####(#%%%%%%%%%%%%%%%%%%%%%%
(((((((((#((((((/(((///((/##%%%%%%%%%%%%%%*#####(((((((((///((#%%%%%%%%%%##(((((((/(###########(%#(#%%%%%%%%%%%%%%%%%%%%
###(#(##(#(#((##((#(((#(##%%%%%%%%%%%%%%%##((((((((((/(((((######(//////////////(((/((((((((*(#%%%%%%%%%%%%%%%%%%%%%%%%%
#########(##############%%%%%%%%%%%%%%%%%%(/((/////////////(((((((//(//(((//(/((((///(/,,*#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%#%%%#%%%#%#####%%%%%%%%%%%%%%%%%#/(((#(((((////(//*////(((((((/(/((#((((((#((#%%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%%%";
        string _54 = @"
********************************,,,,,,,,*,,/**,,,,****,,,,,,,,,,,,*,*,**************************************************
*******************,,*****,,,,**********,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
*********************,,*****,,,*,,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
,****************,,,,,,..,,,.,,,,,,********,,.,,,,,,,,,,,,,,,,.,,.......,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
######/,,,,,,,,,,,,,..,,,,,,.......,,,..,,,,,,,,,,,.,......,,,,,..........................................,,,,,,,,,,,,,,
#########%%%%%#(,,..............................................................................................,,,,,,,,
#########%%%%%%%%%%%%(..................................................................................................
########%%%%%%%%%%%%%%%%%%,....................................................(%%%%%%%##,..............................
######%%%%%%%%%%%%%%%%%%%%%%%%%%%/,.........................................*%%%%%%%%####((*............................
%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(................               .....#%%%%%%####((//**...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##%%##((((((((((//*.               ..#%%%%#####((//**,,..........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&%#/(%%%((((((((((((((//*       .(#%%%#####(((//**,...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%&&&&&&&&&&%//%%%%%################((////*/######(((////*,,,......,,,,...............
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%#&&&&&&&&&&&&%#,/%%%%%%%##################((#%####(((((/////***,*,**,***,,,............
%%%%%%%%%%%%%%%%%%##%#%%%%%%%%%#%&&&&&&&&&&%%%%//#&&&&&%%##%##############(((/*#(*,((((((((///////*/////////**//////////
%%############%%%%%##%%%%%%%%%(#%&&&&&&&&&%%%%#*#%&%%%%%#&&%%#%#%%%#(##########,.*//(###((((((((///((((((((((((*/(((((((
##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%%#*,*#%%%%%%%&&%%%%%%%%%%####%%#####*,,*#(#########(((((((((((#########/(((((
#####%%%%%%%%%%#####%%%%%%%%%%%&&&&&&&&%#(#/**/(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(*..//###############################((##
#####%%%%%%######%%%%%%%%%%##%&&&&&&%%%%%##(*/#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%/##(#%%%######################%##%%%%#(#
#####%%%%%%%%%%%%%%%%%%%%%%(%&&&&%%%%%%%%#####((%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(%%%%%%%%############%%%%%%%%%%%%%%%%#
(#%##%%%%%%%%%%%%#%%%##%%%%%%%%%#(((((##(##%%%%###(#(%%##%%%%%%%%%%%%%%%%%%%%%%#(%%%%%%%%%%###%%%%/#%%%%%%%%%%%%%%%%%%%%
%%##%%#%#%##(%%#%#(##%######(#%%#((((((#%##((%#%%%%%%%%%((#%%%##%%%%%#######%%%%%%%%%%%%%%#####%%(%##%%%%%%%%%%%%%%%%%%%
/((%%%######((((#(((((((((((##%%#((((#%%%##//((((#((((%%%%%%%%%%%##########%%%%%%%%%%%%%#%%%#%%%#%##%%%%%%%%%%%%%%%%%%%%
(((((((((#((((((/(((///((((##%%%%%%%%%%%%%((((#####((((((///(/(%%%%%%%%%%%#(((((((((###########/###(%%%%%%%%%%%%%%%%%%%%
########(#(((((#((##((#(##%%%%%%%%%%%%%%%%#((((((((((/((((#######(///////////////(//((((((((*/#%%%%%%%%%%%%%%%%%%%%%%%%%
#########################%%%%%%%%%%%%%%%%%#//(//(/////////((((((/(/////(((//(/((((///(/,,*(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%#%%%#%%%#######%%%%%%%%%%%%%%%%%%#(((#((((((//((///////(((((((/(/((#(((((((#(#%%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%%%";
        string _55 = @"
********************************,,,,,,,,*,,/**,,,,****,,,,,,,,,,,,***,**************************************************
*******************,,*****,,,,**********,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
*********************,,*****,,,*,,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
,****************,,,,,,..,,,.,,,,,,********,,.,,,,,,,,,,,,,,,,.,........,,,.....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
######*,,,,,,,,,,,,,..,,,,,,.......,,,..,,,,,,,,,,,........,,,,,..........................................,,,,,,,,,,,,,,
#########%%####/,,...............................................................................................,,,,,,,
#########%%%%%%%%%%%%(..................................................................................................
########%%%%%%%%%%%%%%%%%%,...................................................*%%%%%%%%%##..............................
######%%%%%%%%%%%%%%%%%%%%%%%%%%%/,............................. ...........*%%%%%%%%%###(((............................
%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#.................  .....       .....(%%%%%%%###((//**,..........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##%%#(((((((((((//,              ...#%%%%%#####((/**,,..........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&%#/#%%#((((((((((((((//.       .*%%%%%####(((/**,,..........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%&&&&&&&&&&&%*/%%%%%#####%#########((//////##%####((////***,,.....,,,*,..............
%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%%%#%&&&&&&&&&&&&%**(%%%%%%%###################(%#######((((///**********////*,..,,,.....,
%%%%%%%%%%%%%%%%%%#%%#%%%%%%%&%%#%&&&&&&&&&&%%%#//%&&&&&%#(###%#%%#########(((*(#/**(##((((((/////////////((/*//////////
%%###########%%%%%%##%%%%%%%%&%(#&&&&&&&&&&%%%%,((%%%%%%#&&%%#%%%%%%(#%%#######(.*//(######((((((((((((((((((##(*/((((((
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%%#*,/%%%%%%%&&%&&%%%%%%%###%%%%%%%%#,,,#(###########((((((#############/##((
###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%%#((/**/#%%%%%%%%%%%&&&&%%%%%%%%%%%%%%%#/*,*/################################(##
###%%%%%%%%%#%##%%%%%%%%%%%%##&&&&&&&&%%%%##//(%%%%%%%%%%&&&&&&&&&%%%%%%%%#%%%%%%#%#%%%%%%%%%%%#############%%%%%%%%%%#(
#####%%%%%%%%%%%%%%%%%%%%%%#(%&&&&#%%%%%%%##%%#(#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%###%#%%%%%%%%%%%%%%%%%%%%%%%
(#%#%%%%%%%%%%%%%%%%%#%%%%%%%%%%%((#((##((##%#%%%%%#(#(##%%%%%%%%%%%%%%%%%%%%%%(((%%%%%%%%%#(%%%%%(%%%%%%%%%%%%%%%%%%%%%
%%##%%#%#%##(%%#%#(##%#(##(#(##%#((((((##%##/(%%%%%%%%%%%#((%%%%%%%%########%%%%%%%%%%%%%%#(%%%%%(%%%%%%%%%%%%%%%%%%%%%%
/((%%%%#####(#(((((((/(((((((##%##(((##%%%%#/(((((((#((#%%%%%%%%%%#%#######%%%%%%%%%%%%%(#%%%%%%#%((%%%%%%%%%%%%%%%%%%%%
(((((((((#((((((((((//((((((#%%%%%%%%%%%%%%#(((((###(((((/////(#%%%%%%%%%%##(((((((##(((##(####(##((%%%%%%%%%%%%%%%%%%%%
###(#(##(#(#((###(##((#(###%%%%%%%%%%%%%%%%#(((((((((/((((#######(/////////(////////((((((((*/%%%%%%%%%%%%%%%%%%%%%%%%%%
#########(############(#(#%%%%%%%%%%%%%%%%%#/(////////////((((/(((/////(((//(//(/(/////*,*(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%#%%%%%%%#%#######%%%%%%%%%%%%%%%%%(((((((((////(//*////(((((((/(/((##((((#/(###%%%%%%%%%%%%%%%%%&&&&%%%%%%%%%%%";
        string _56 = @"
********************************,,,,,,,,,,*/**,,,,**,,,,,,,,,,,,,,,**,**************************************************
*******************,,*****,,,,**********,,,,,,,,.,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
*********************,,*****,,,*,,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***
,****************,,,,,,..,,,.,,,,,,********,,.,,,,,,,,,,,,,,,,..........,,,.....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
######*,,,,,,,,,,,,,..,,,,,,.......,,,..,,,,,,,,,,,........,,,,,..........................................,,,,,,,,,,,,,,
#########%%####/,................................................................................................,,,,,,,
#########%%%%%%%%%%%%(..............................................................,...................................
########%%%%%%%%%%%%%%%%%%....................................................(%%%%%%%%%%#/.............................
######%%%%%%%%%%%%%%%%%%%%%%%%%%%(.............................. ...........*%%%%%%%%%%###((,...........................
%%%%##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#,.................        ..........(%%%%%%%%###((/***..........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#####(((((((((((//,.             ...#%%%%%%####((//*,,..........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%#/#%#((((((((((((((//,       ..%%%%%%###(((/**,,..........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%&&&&&&&&&&&&(*%%%%%#####%#########((((//*/%%%%###(((///***,,,,.,,,,***..............
%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%%%##&&&&&&&&&&&&%%,*%%%%%%%###################(%%#######((((////*******/////*,,,***,,,,,/
%%%%%%%%%%%%%%%%%%#%%#%%%%%%%&%%%#&&&&&&&&&&%%%%*/#&&&&&%#(###%#%%%%#######(((/*#(/,/####((((((////////((((((//////////(
%%###########%%%%%%#%%%%%%%%%&%%/%&&&&&&&&&%%%%#*#%%%%%%#&&%%%%%%%%%(#%%%#%#####,***(#######((((((((((((((######(*((((((
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%%#*,,%#%&%%%&&%&&%%%%%%%%#%%%%%%%%%%*,*(###############################(####
###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&%%(#/(*/(%%%%%%%%%%%&&&&%%%%%%%%%%%%%%%%(**,/#%%%####################%%%%%%%##(#
###%%%%%%%%%#%##%%%%%%%%%%%%%#%&&&&&&&%%%%%##/(#%%%%%%%%%&&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%######%%%%%%%%%%%%%%%%%#
#####%%%%%%%%%%%%%%%%%%%%%%%((&&&&%%%%%%%%%%%%%#(#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%
(#%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%#((#(########%%%%%%%#(##%%%%%%%%%%%%%%%%%%%%%%#(/%%%%%%%%%%/%%%%%#%%%%%%%%%%%%%%%%%%%%%
%%%#%%#%#%%##%%######%((##(#(##%%#((((((#%%##/%%%%%%%%%%%%#/#%#%%%%%%((((###%%%%%%%%%%%%%%%/%%%%%#%%%%%%%%%%%%%%%%%%%%%%
/((%%%%#####(#((#((((/(((((((##%%#((((#%%%%#((########((#%%%%%%%%%%%%%%####%%%%%%%%%%%%%%(%%%%%%%%(#%%%%%%%%%%%%%%%%%%%%
(((((((((#((((((((((//((((((#%%%%%%%%%%%%%%%#((/(((((#(((/////((%%%%%%%%%%%#(((((((##(((##(####(###/%%%%%%%%%%%%%%%%%%%%
###(#(##(((#((##((#(((#(##(#%%%%%%%%%%%%%%%%((((((((//(((((######(/////////(////////(((((((((*##%%%%%%%%%%%%%%%%%%%%%%%%
#########(############(#((%%%%%%%%%%%%%%%%%%(///(////////(((((/((((////(((//(//(/(//////*,/%%%%%%%%%%%%&%%%%%%%%%%%%%%%%
%%%%%%%%%#%%%%%%%#%#######%%%%%%%%%%%%%%%%%%/(((((((////(//*////(((((((/(/((##((((#//###%%%%%%%%&&%%%%%&&&&&&&&&&&&&%%%%";
        string _57 = @"
********************************,,,,,,,,,,*/*,,,,,**,,,,,,,,,,,,,,,**,**************************************************
*******************,,*****,,,,**********,,,,,,,,.,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
*********************,,*****,*,*,,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***
,****************,,,,,,..,,,.,,,,,,********,,.,,,,,,,,,,,,,,,,..........,,,.....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
######*,,,,,,,,,,,,,..,,,,,,......,,,,..,,,,,,,,,,,........,,,,,..........................................,,,,,,,,,,,,,,
#########%%#%##*,................................................................................................,,,,,,,
#########%%%%%%%%%%%%/..............................................................,,..................................
########%%%%%%%%%%%%%%%%%%....................................................#%%%%%%%%%%#(.............................
######%%%%%%%%%%%%%%%%%%%%%%%%%%%(..........................................*%%%%%%%%%%####(*...........................
%%%%##%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%%%%#.................         ..........(%%%%%%%%%##((//**..........................
%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%%%%##(#((((((((((((//,              ...#%%%%%%%####(//**,..........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%%/(##((((((((((((((//,       ..%%%%%%####((//**,..........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%&&&&&&&&&&&&%*(%%%%###%%%%%#######((((//*(%%%%%###((((//**,,,,.,,*****,.............
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%##&&&&&&&&&&&&&%/*%%%%%%%###################(%%%######(((((///**/*//*/////*,,,****,,,*/
%%%%%%%%%%%%%%%%%%#%%#%%%%%%%%%%%#%&&&&&&&&&&%%%//(&&&&&%#####%%%%%%%#########(,##(*/(####((((((((//((((((((((*//////(((
%%######%####%%%%%%#%%%%%%%%%&%%#(&&&&&&&&&&%%%%,#(%%%%%%&&&%%%%%%%%(%%%%#%%%%%#(,,((##########(((((((((#########(((((((
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%&&&&&&&&&%%%/,,*%%&%%&&&&&&&%%%%&%%#%%%%%%%%%%(,,/###%############################/###
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%%##(///*/%%%%%%%&&&&&&&&&%&&%%%%%%%%%%%#*/,/%%%%%%%%%#%#########%%%%%%%%%%%%#(#
##%%%%%%%%%%%%%%%%%%%%%%%%%%%%#&&&&&&&&%%%%%%#((%%%%%&%%&&&&&&&&&&&&&%&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#
###%%%%%%%%%%%%%%%%%%%%%%%%%%#%&&&%%%%%%%%%%%%%%#(#%%#%%&&&&&&&&&%%&&&&&&&&%%%%%%%%(%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%#%%%%#%%%%%%%%%%%%((((#####%#(#%%%%%%%%/#%%%%%%%%&%%%%%%%&%%%%%%#(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%#%%%##%#%###%%%#(#%%%######(##%%%((((((#%%%#((%%%%%%%%%%%%%/#/#%%%%#/%%#(/##%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%
(((%%%%%####((##((((((((((((((#%%##(((##%%%%#*#######%%%#(#%%%%%%%%%%%#####%%%%%%%%%%%%%%(%%%%%%%%###%%%%%%%%%%%%%%%%%%%
((((((((((((((((((((/(((((/((#%%%%%%%%%%%%%%#(//((/((((/(////((/%%%%%%%%%%%%#((((((##((((#((###(%(#/%%%%%%%%%%%%%%%%%%%%
#####(##(((#(######((##(##(#%%%%%%%%%%%%%%%%#/((((((//(((((######(/////////(////////(((((((((/(#%%%%%%%%%&&%%%%%%%%%%%%%
###%#############(####(##(#%%%%%%%%%%%%%%%%%%/((//////////(#(///(((//(/(/((/(//(/(///////**#%&&&&&&&&&&&&&&&&%%%%%%%%%%%
%%%%%%%%%%#%#%%%##%###%####%%%%%%%%%%%%%%%%%(##(#(((/(((((///(//((((((((((((##(((#(//(%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&%%%%";
        string _58 = @"
********************************,,,,,,,,,,*//*,,,,**,,,,,,,,,,,,,,****,*************************************************
*******************,,*****,,,***********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
*********************,,*****,,**,,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
**************,**,,,,,,,.,,,.,,,,,,********,,.,,,,,,,,,,,,,,,,,........,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
######/,,,,,,,,,,,,,....,,,,......,,,,..,,,,,,,,,,,........,,,,,.........................................,,,,,,,,,,,,,,,
###########%%##*,................................................................................................,,,,,,,
########%%%%%%%%%%%%%(.............................................................,(*,,................................
########%%%%%%%%%%%%%%%%%%...................................................*%%&&&&%%%%%%#.............................
#####%%%%%%%%%%%%%%%%%%%%%%%%%%%%#.............................. ...........*%%%&&%%%%%%###(/...........................
%%%%##%%%%%%%%%%%%%%%%%%&&&%%%%%%%%%%%%%,.......................  ..........(%%%%%%%%%%##((//*..........................
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%%%%##//((((((((((//*.             ...%%%%%%%%%%##((//*,..........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%&&&&&&&&&%((#(((((((((((((((/*      ...%%%%%%%%###((/**,,.........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%&&&&&&&&&&&&(*%%%%####%%%%%########((((/#%%%%%%###((((///**,,,,,****,*.............
%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%%%%&&&&&&&&&&&&%#**%%%%%%###################(%%%%%#%#####((/////////////((/*********///
%%%%%%%%%%%%%%%%%%#%%%%%%%%%%&&%%%(&&&&&&&&&&%%&%(/&&&&&%%###%%%%%%%%##########*(##/,(########(((((((((((((#((/*//((((((
%%###########%%%%%%#%%%%%%%%&&%%%(%&&&&&&&&&%%%%.(#%%%&%%&&%%%%%%%%%#%%%%#%%%%%##.,#(#%%%#########################/(((((
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%&%%#&&&&&&&&&&%%#*.*%#&&&&&&&&&&&&%&&&%#%%%%%%%%%%#,,/#%%%%%%%%#############%%%%%%%%%#(###
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&%%%#/(,//#%%&&&&&&&&&&&&&&&&&&&%%%&&&&%%(//(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##
#%%%%%%%%%%%%%%%%%%%%%%%&%%%&%%%&&&&&&%%%%%%%%##(#%%&&%&&&&&&&&&&&&&&&&&&%%%&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%###%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&#%%%%%%%%%%%%%%#(%%%%&&&&&&&&&%%&&&&&&&&%%%%%%%%#%%%%%%%%%%##%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%#%%%%#%%%%%%%%(%%%#(#######%%#*#%%%%%%%%/#%%%%%%%&&%&%%%&&%&&%%%%(%%%%%%%%%%%(%%%%%%%%%%%%%%%%%%%%%%%%%%
%##%%#%%%%%#(%#%##%%%%#%#%######%%#((((((#%%%#*#(((#%%%%%%%%%(/##%##*#%%%%#/(%%%%%%%%%%%%%%%(%%%%%%#%%%%%%%%%%%%%%%%%%%%
((###%#%#####((#((((((((((((((#%%%###((#%%%%%#######%%%%##(#%%%%%%%%%%((((#%%%%%%%&&&&&&%%(%%%%%%%#%/%%&&%%%%%%%%%%%%%%%
(#((((((#(((((((((((/((((((((#%%%%%%%%%%%%%%%(((((/((((/(//(/((/%%%%&&&&&%%#((((((/##(#((#((###(%(%/%%%%%%%%%%%%%%%%%%%%
#####(######(######((##(#(((#%%%%%%%%%%%%%%%%/(((((((((((((###%##(////(////(////////((((((((((*#%%%%%%%%%%%%%%%%%%%%%%%%
###%%%#%#################(#%%%%%%%%%%%%%%%%%%*((/(///////((#(/(//(((((/(/((/(////(//(//////*%&&&&&&&&&&&&&&&&%%%%%%%%%%%
%%%%&%%%#%%%#%%%##%########%%%%%%%%%%%%%%%%#%#((((((/(((((////((((((#(((((####(((#(/(/(%#%%%%&&&&&&&&&&&&&&&&&&&&&&&&&%%";
        string _59 = @"
********************************,,,,,,,,,,*//*,,,,**,,,,,,,,,,,,,,****,,,,,,,*******************************************
*******************,,*****,,,***********,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
*********************,,*****,,**,,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
,*,***********,**,,,,,,,.,,,..,,,,,*********,.,,,,,,,,,,,,,,,,,..........,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
######(,,,,,,,,,,,,,....,,,,,.....,,,,..,,,,,,,,,,,........,,,,,.........................................,,,,,,,,,,,,,,,
############%##(,................................................................................................,,,,,,,
########%%%%%%%%%%%%%(...........................................................,.*##/*................................
########%%%%%%%%%%%%%%%%%%,................................................../%%&&&&%%%%%%#.............................
#####%%%%%%%%%%%%%%%%%%%%%%%%%%%%%,.........................................*%%%%&%%%%%%###((...........................
%%%%##%%%%%%%%%%%%%%%%%%&&&%%%%%%%%%%%%%/.......................  ..........(%%%%%%%%%%##((//*,.........................
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%#%%%%(/((((((((((///.             ...%%%%%%%%%%###((/*,..........................
%%%%%%%%%%%%%%%#%%%%%%%%%%%%&%%%%%%%%%&&&&&&&&&&#(((((((((((((((((/*.     ...%%%%%%%%###((//**,.........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%&&&&&&&&&&&&#,(%%%%###%%%%%#########((((#%%%%%%%###(((///**,*,*,****,*.............
%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%%%#&&&&&&&&&&&&%%**%%%%%%###################(#%%#%%%%#####((((///////((((((/,******////
%%%%%%%%%%%%%%%%%%#%#%%%%%%%%%&%%%(&&&&&&&&&&&%%%//&&&&&%%###%%%%%%%%##%#######//##/,(########(((((((((((((###(,*/((((((
%%###########%%%%%%%%%%%%%%%&&%%%##&&&&&&&&&%%%%./(%%%&%%&&%%%%&%&%%#%%%%#%%%%%##,,(##%%%%########################/(((##
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%&%%#&&&&&&&&&&###,,,(#&&&&&&&&&&&&%&&&%#%%%%%%%%%%%*,/#%%%%%%%%%###########%%%%%%%%%%##(##
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&%%%#//*//(%%&&&&&&&&&&&&&&%&&&&%%%&&&&%%#/((%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/
#%%%%%%%%%%%%%%%%%%%%%%%&%%%&%%%&&&&%&%%%%%%%%##/(%%&&%&&&&&&&&&&&&&&&&&&&%%&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%##%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&#%%%%%%%%%%%%%%#/#%%%&&&&&&&&&%%&&&&&&&&%%%%%%%%#%%%%%%%%%%##%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%#%%%%#%%%%%%%%(%%%#(#######%%#/(#%%%%%%%#(#%%%%%%&&%&%%%&&%&&%%%%(%%%%%%%%%%%(%%%%%#%%%%%%%%%%%%%%%%%%%%
%##%%#%%%%%##%#%##%%%%#%%%%(####%%%((((((#%%%#/##((##%%%%%%%%%((##((/%%%%%#((%%%&%%%%%%%%%%%##%%%%%#%%%%%%%%%%%%%%%%%%%%
((#####%#####((#((((((((((((((#%%%###(##%%%%%#######%#####(((%%%%%%%%%##((#%%%%%%%&&&&&&%%(%%%%%%##%/%%%&%%%%%%%%%%%%%%%
(#((###(#(((((((((((/((((((((#%%%%%%%%%%%%%%%#/(/(/(/((/(//(/((/%%%%&&%&&%%#((((((/##(#((#((###(%/#*%%%%%%%%%%%%%%%%%%%%
############(######((##(#(((#%%%%%%%%%%%%%%%%((((((((((((((###%##(////(////(////////((((((((((*##%%%%%%%%%%&&%%%%%%%%%%%
###%%%#%#################(##%%%%%%%%%%%%%%%%%*((//////////(((/(//(((/(/(/((/(////(//(//(///*(&&&&&&&&&&&&&&&&%%%%%%%%%%%
%%%%%%%%#%%%%%%%##%########%%%%%%%%%%%%%%%%%##((((((/(((((////((((((#((((((###(((#((//((##%%&&&&&&&&&&&&&&&&&&&&&&&&&&%%";
        string _6 = @"
*****************************////////////////////////(((((((((((((((((##########################################%%%%%%%%
,,,**,,***************************/////////////////////////////((((((((((((((((((((((((#################################
,,,,,,,,,,,,,,,,,,,,*************************************//////////////////((((((((((((((((((((((((((((#################
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**********************************///////////////////////(((((((((((((((((((((((((((((((((
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************///////////////////////////////((((((((((((((((((((
.........,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************************//////////////////////////////(((((((((
...........................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************/////////////////////////////
......................................,,,,,,,,,,,,/%%/,,,,,,,,,,,,,*******************************//////////////////////
#####(,......................................,,,%&&&&&&&/,,,,,,,,,,,,,,,,,,,*********************************///////////
############%%/..............................,*%&&&&&&&&&#,,,,,,,,,,,,,,,,,,,,,,************************************////
#######%%%%%%%%%%%%%%%%%%%%..................(#%&&&&&&&&/,,,,,,,,,,,,,,,,,,,,,,,,,**************************************
%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%#*........,//%&&&&&&&%,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,**********************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%////&&&&&&&&&&.....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************
##%%%%%%%########%%%%%%%%%%&&&%&%%%%%%%%/(*#&&&&&&&&&&&%%%%%%%%%/,,,,,,,,,,,,,,,****************************************
#############%%%#%%%##########%%%%%%%###**(&&&&&&&&&&&&###%%%%&&&&&&&&&&&&&&%%%%%##(//**********************************
###############################%%%%%%%%%**#&&&&&&&&&&&%####%%%%%%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%#/*////**////
####%%%%%%%##%##########################*/%&&&&&&&&&&&&%%%%%&&&&%%%###%%%%%%&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&(
%#%%%%%%#################%#############,*%%&&&&&&&&&&&&##/(&@&&&%###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%####%%%%%###############%%%%%%%%#**(&&&&&&&&&&&&&&&*/%&&@@@%%%####################%##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%##%%%#%%**/%&&&&&&&&&&&&&&&%#(#&&&&&&&&&%%%%%%##%%%###########%#%#######%%%%%%%%%%%%%%%%%%%%
########%#%#####%########%%###%%%%%,*(%&&&&&&&&&&&&&&&&%(//#&&&&&&%&&&&&&%%%%%%&&#%%%%%%%%&&&&&&%###%#######%%%%%%%%%%%%
((((#((((((((((((((((((/(((((((((((((%&&&&&&&&&&&&&&(&&&&%%%#&&&&&%%%##&&%%%%%&&&%%%%%%%%#%&&%#%%%%#%%%%%###%##%%%%%%###
#######(###%####(#######%####(#(((((%%&&&&&&&&&&&&&&%%%(#(%%%%&&&&&%((((#(############(##(((((#(##(#########((##########
#####################%##########%#%%#(&&&&&&&&&&&&&&&##%#%&#%%%%%%%%########(#############%#%%###########%%##%%%%%#%#%#%
#%%%%%%%%###########((############(&%(&&&&&&&&&&&&&&&%####/%%%%%%%%%%###((####(#%%%%%%%##########%#####################%
&%%%%&&%%%%%%%%#######%#(###(#####%&##&&&&&&&&&&&&&&&%#####%%%%%%%%%%###%#%%%%%&&%%%%%%%%%%#%###%%###%%##%%#####%#%###%%
&&&&&&&&&&&&&&&&%%###%%%&&%%%####/&&#&&&&&&&&&&&&&&&&&####(/%%%&%%%%%%%&%%%%#%%%%%#%%%#%%%%%%%%#%%%%#%#%#%%%%%%%%%%%#%##";
        string _60 = @"
********************************,,,,,,,,,,*//*,,,,**,,,,,,,,,,,,,,****,,,,,,,,,,,,,,*********,,*************************
*******************,******,,,***********,,,,,,,.,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
*********************,,*****,,***,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
,**,**********,**,,,,,,,.,,,,.,,,,,*********,.,,,,,,,,,,,,,,,,,............,,.......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
######/,,,,,,,,,,,,,....,..,,,....,,,,..,,,,,,,,,,,........,,,,,.........................................,,,,,,,,,,,,,,,
###########%#%%(,................................................................................................,,,,,,,
########%%%%%%%%%%%%%(...........................................................,.(#%#(................................
########%%%%%%%%%%%%%%%%%%,..................................................#%%&&&&&&%%%%#,............................
#####%%%%%%%%%%%%%%%%%%%%%%%%%%%%#*........................................./%&&&&&&%%%%%###(...........................
%%%%##%%%%%%%%%%%%%%%%%%&&&&%%%%%%%%%%%%/.......................  ..........(%%&&&%%%%%%##(///,.........................
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%%%%%%%%%&&&&(/(((((((((///.             .. %%%%%%%%%%%###(/*,..........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%&&&&&&&&&&&/((((((((((((((((/*.     ..,%%%%%%%%%###(///*,.........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%&&&&&&&&&&&&&*/%%%%##%%%%%%%#########(((%%%%%%%%#####(((/****,**/*//.*.............
%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%%%%%#&&&&&&&&&&&&%%*/%%%%%%%#%###%%%%%########(#%%#%%%%%#####(((/(//(//((((((/,*****/////
%%%%%%%%%%%%%%%%%%#%%%%%%%%%%&&%%%/&&&&&&&&&&&%%%*/%&&&&%%###%%%%%%%%##########/*#%(,/%%%######(##((((########(,*(((((((
%%#######%###%%%%%%%%%%%%%%&&&%%&##&&&&&&&&&&%%#,,(#%%&%&&&%&%%&&&%%#%%%%%%%%%%%#**##%%%%%%##################%%%%#((((##
%%%%%%%%%%%%%%%%%%%%%%%%%&%&&%&&%%&&&&&&&&&&###./.,#&&&&&&&&&&&&%&&&%#%%%%%%&%%%%,,(#%%%%%%%%%%%%######%%%%%%%%%%%%%#(##
%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%&&&&&&&%%%%(*(///%%&&&&&&&&&&&&&&&&&&&&&&&&&&&%#*##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/
%%%%%%%%%%%%%%%%%%%%%%%%&%%%&%%%&&&&%&%%%%%%%%%#(/#&&&%&&&&&&&&&&&&&&&&&&%%%&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%#%%%%%%%%%%%%%%#(%%&&&&&&&&&&%%&&&&&&&&&%%%&&&%(%%%%%%%%%%##%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%########%%%((#%%%%%%%%((%%%%%&&&%&%%%&&%&&%%%%(%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%&%%%%%%%
%%#%%%%%%%%(%%%%##%%%##%##%(###(%%%#((((((%%%#(####%#%%%%%%%%%#/##(/(%%%%%%%(%%%%%%%%%&&&%&%%#%%%%%%%%%%%&&%%%%%%%%%%%%%
((#%%%%%#####((#(#(#(((((((((((%%%%##((#%%%%%%########(#(((((%%%%%%%%%#%((#%%%%%%&&&&&&&%%(%%%%%%(#%/%%%&%%%%%%%%%%%%%%%
(#(##(#(##(((((((((/((((((((((%%%%%%%%%%%%%%%%/(/(((/((//////(((%%%&&&&&&&%#(((((((####(##((####%/#/%%%%%%%%%%%%%%%%%%%%
############(######(##(##(#(#%%%%%%%%%%%%%%%%#(((((//(((##(##%%##(////(////((//////(((((((((((/##%%%%&&&&%%&&%%%%%%%%%%%
##%%####(############(#(((##%%%%%%%%%%%%%%%%#(/(/////////((((((/(/((///(////(///((///(////(//%&&&&&&&&&&&&&&&%%%%%%%%%%%
&%%%%%%%#%%%%%%%#%###%######%%%%%%%%%%%%%%%%(#((((#((/(((/*/(//(((((#(((((#####(##(//((*##%%&&&&&&&&&&&&&&&&&&&&&&&&&&%%";
        string _61 = @"
********************************,,,,,,,,,,*//*,,,***,,,,,,,,,,,,,,****,,,,,,,,,,,,,,*********,,*************************
*******************,*******,,***********,,,,,,,.,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
*********************,,*****,,***,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
,*,***********,**,,,,,,,.,,,,.,,,,,*********,.,,,,,,,,,,,,,,,,.............,,.......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
######*,,,,,,,,,,,,,....,..,,,....,,,,..,,,,,,,,,,,........,,,,,.........................................,,,,,,,,,,,,,,,
###########%#%%/,................................................................................................,,,,,,,
########%%%%%%%%%%%%%,...........................................................,,#%%#(................................
########%%%%%%%%%%%%%%%%%%,..................................................%%&&&&&&&%%%%#.............................
#####%%%%%%%%%%%%%%%%%%%%%%%%%%%%#,.........................................#%&&&&&&%%%%%%##(...........................
%%%%##%%%%%%%%%%%%%%%%%%&&&&%%%%%%%%%%%%,...... ................    ........%%&&&&&&%%%%%#((//,.........................
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%%%%%%%%&&&&&%//((((((((//*.             ...%%%%&&%%%%%%##((/*,.........................
%%%%%%%%%%%%%%%#%%%%%%%%%%%%&%%%%%%%%%&&&&&&&&&&&#*(((((((((((((((/*      ..*%%%%%%%%%%##((//*,,........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#&&&&&&&&&&&&&(,%%%%##%%%%%%%#########(((%%%&%%%%%#####((///****/////.,.............
%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%%%%%(&&&&&&&&&&&&%%/*%%%%%%######%%%%%########(%%%%%%%%%%####((((((((((((((((*******/////
%%%%%%%%%%%%%%%%%%##%%%%%%%%%&%%%%#%&&&&&&&&&&&%%%/(&&&%%%##%%%%%%%%%##########/*%%(*/%%%%#####################,/(((((((
%%#######%#%%%%%%%%%%%%%%%%&&&%&&%#%&&&&&&&&&%%%,,((%%%%&&&%&%%&&&%%#%%%%%%%%%%%#**%#%%%%%%%%%###########%%%%%%%%#((((##
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%&&&%%&&&&&&&&&(*/*/,,%%&&&&&&&&&&&&&&%%%%%%&%&%%%%%,,#(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/##
%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%&&&&&&&%%%%#,(*/(%&&&&&&&&&&&&&&&&%&&&&&&&&&&&%#*#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%/
%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%&&&#&%%%%%%%%%%#(/%&&&&&&&&&&&&&&&&&&&&&&%%&&&&%%%%%%&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%&&&%#%%%%%%%%%%%%%%%/#%&&&&&&&&&%%&&&&&&&&&%%%&&&&%#%&&%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%#%%%%#%%%%%%%%%%%%%%###(##(#%%%#*/#%%%%%%%%/##%%&&&%&&%%%&&%&&&%%%(%&%%%%%%%%%%(%%%%(%%%%%%%%%%%%&&%%%%%%
#%%%%%%%%%##%#%##%%%%#####%####(%%%#((((((#%%%#######%%%%%%%%%%#/###/%%%%%%%#%%%%%%&&&%&&%%&%(%%%%%%%%%%%&&%%%%%%%%%%%%%
((#%%%%####(#(##(#(((((((((((((%%%%%##(##%%%%%#(((#((((#((((((%%%%%%%%##//(#%%%%%&&&&&&&&%%#%%%%%(%#/%%%&&&%%%%%%%%%%%%%
#((###(#(((((((#(((/((((((((((#%%%%%%%%%%%%%%%/((/((((/(////(%%%%%%&&&&&&&%%#(((((#####(#((######(/##%%%%%%%%%%%%%%%%%%%
#######(#(########((##(##((##%%%%%%%%%%%%%%%%(((((((/((((####%###(////////(/(//////((((((((((((*/%%%%&&&&&&&&&&%%%%%%%%%
##%%##%#################(#(#%%%%%%%%%&%%%%%%%((/(((//////(#(///(((////(/((/(//(((//(//////////%&&&&&&&&&&&&&&&&%%%%&%%%%
%%%%%%%#%%%%%%%#%####%####(#%%%%%%%%%%%%%%%%/#(#(((/(((((///(((((((#(((((((##(#(((///(((/((%%&&&&&&&&&&&&&&&&&&&&&&&&&%%";
        string _62 = @"
********************************,,,,,,,,,,///*,,,**,,,,,,,,,,,,,,,***,,,,,,,,,,,,,**************************************
**************************,,,***********,,,,,,,.,,..,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
********************,,*******,**,,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
,*,***********,**,,,,,,,.,,,..,,,,*********,,.,.,,,,,,,,,,,,,,......................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
######*,,,,,,,,,,,,,...,....,.....,,,,.,,,.,,,,,,,,........,,,,,.........................................,,,,,,,,,,,,,,,
##########%%%%%*.................................................................................................,,,,,,,
########%%%%%%%%%%%%%,...........................................................,*#%%#/................................
########%%%%%%%%%%%%%%%%%(..................................................,%&&&&&&&&&%%%%.............................
####%%%%%%%%%%%%%%%%%%%%%%%%%%%%%/,............................. ...........%&&&&&&&&&%%%%%#(...........................
%%%%#%%%%%%%%%%%%%%%%%&&&&&&%%%%%%%%%%%#........................    .......,%%&&&&&&%%%%%#(((/..........................
%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%&&%%%%%%%%&&&&&&%(/(((((((//,.             ...%%&&&&&&%%%%%##(/*,.........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%%%%&&&&&&&&&&&&(/(((((((((((((//,      ..#%&%%&%%%%%%##((/**,........................
%%%%%%%%%%%%%%%%%%%%%%%%%%#%#%%%%%%%#&&&&&&&&&&&&&%,(%%##%%%%%%%#########((((%%%&&%%%%%%%###((//*//*///(*.,.............
%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%%%%%#&&&&&&&&&&&&&%#//%%%%%######%%%%%%%%######%&%%%%%%%%%%#####(((((((#####(,******/////
%%%%%%%%%%%%%%%%%#%#%%%%%%%%%&%&&&##&&&&&&&&&&&%%%//&&&%%###%%%%%%%%%#%%%%#####*(%%//#%%%%%%%##################,/(((((((
%%%######%#%%%%%%%#%%%%%%%%&&&%&&%%%&&&&&&&&&%%%,,,#%&%%&&&%&%&&&%%%%%%%%%%%%%%%#*/%#%%%%%%%%%%###%%%%%%%%%%%%%%%%(#####
%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%&&&%%&&&&&&&&%%/*(,*,/#&&&&&&&&&&&&&&%%%%&&&&&&&%%%*,%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%/##
%%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%%%&&&&&&&&%%%%/**//(&&&&&&&&&&&&&&&&&&&&&&&&&&&&%#*#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(
%%%%%%%%%%%%%%%%%%%%%%%&&&&%%%%%%&&&%#&%%%%%%%%%#/(#&&&&&&&&&&&&&&&&&&&&&&%&&&&&&%%(%&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%&&&##%%%%%%%%%%%%%%#/%&&&&&&%&&&&&&&&&&&&&%%%&&&&%%&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%(####(##%%%*#/%%%%%%%%#/%%%%&&%&&&%&&&&&&&%%%(%&&&%%%&&&&%(%%%%(%%%%%%%%%%%%&&%%%%%%
%#%%%%%%%%##%%%###%%##%%%%(###((%%%%#((((##%%%#(#####%%%%%%%%%%%#(###%%%%%%%(#%%&&%&&&%&&&&&&%%%%%%%%%%%%&&&&%%%%%%%%%%%
(#%##%%%########(((((((((((((((%%%%%#####%%%%%%(((((((###(((((%%%%%%%%#(/*###%%%%%&&&&&&&&%%%%%%%#%(/%%&&&&&&&&%%%%%%%%%
#((#(#(##(((((((((((((((((((((#%%%%%%%%%%%%%%%*((/((((/(//((/(#%%%%%&&&%&&&&&%###(#####(#((#######((/%%&&&&&&%%%%%%%%%%%
##################((#(##(#(%#%%%%%%%%%%%%%%%%%*(((((((((((#####%%%%(/(////(////////((((((((((((/,%%%%&&&&&&&&&&&%%%%%%%%
#%%#%#%###############(((#((%%%%%%%%%%&%%%%%%((//(//////((#(((//(((((/((((/(//(/(//(/////(////*#%&&&&&&&&&&&&&&%%%%%%&%%
%%%%%%%%%%#%%%%#%####%######%%%%%%%%%%%%%%%%%(#(#((//(((//////(((((#(((((####(((#//((((((///%&&&&&&&&&&&&&&&&&&&&&&&&&%%";
        string _63 = @"
********************************,,,,,,,,,*///,,,,**,,,,,,,,,,,,,,,***,,,,,,,,,,,,,**************************************
**************************,,,**********,,,,,,,,.,,..,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************
********************,,**********,,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****
,,,***********,**,,,,,,,.,,,.,,,,,*********,,,,,,,,,,,,,,,,,,.......................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
######*,,,,,,,,,,,,,...,..,.......,,,,.,,,,,,,,,,,,.......,,,,,..........................................,,,,,,,,,,,,,,,
###########%%%#,.................................................................................................,,,,,,,
########%%%%%%%%%%%%#.............................................................*#%((,................................
#######%%%%%%%%%%%%%%%%%%*...................................................%&&&&&&&&&&%%(.............................
####%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*.............................. ..........*%&&&&&&&&&&%%%%#*...........................
%%%%#%%%%%%%%%%%%%%%%%%&&&&%%%%%%%%%%%%( ..................          ......*%&&&&&&&&&%%%##((/..........................
%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&%&%%%%%%%%&&&&&&&%(/(((((///.              ..*%%&&&&&&&%%%%##(/*,.........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%%%%&&&&&&&&&&&&%*/((((((((((((/*.     ...%%&&&&%%%%%%##((//*,........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%#&&&&&&&&&&&&&%/,%%##%%%%%%%#######((((((&&%&&&%%%%%%%###(//////((((**,.............
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&%%%%%#&&&&&&&&&&&&&%%//%%%%%####%%%%%%%%%%#####%%&&%%%%%%%%%%####(#(##(######(,********///
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%&&&%(&&&&&&&&&&&&%%%(&&&%%###%%%%%%%%##%%%%#####,%%(#%%%%%%%%%%#################,((((((((
%%#########%%%%%%%%%%%%%%%%&&%%&&%%#&&&&&&&&&&%%*,*(%&%%&&&%%%&&&%%#&&%%%%%%%%%%#./%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/#####
%%%%%%%%%%%%%%%%%%%%%%%%&%&&%&&&&&%&&&&&&&&%%*(**/,*#%&&&&&&&&&&&&&%#%%&&&%&&&%%%**#%&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(##
%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%&&%&&&&&&&&%%%%#,*/*/%&&&&&&&&&&&&&&&&&&&&&&&&&&&#/*(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%/
%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%&&&&#&%%%%%%%%%%#((&&&&&&&&&&&&&&&&&&&&&%%&&&&&&%%(&&&%%&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%&&&%##%%%%%#%%%%%%%%/%&&&&&%##%%&&&&&&&&&&%%%&&&&#%&&&%%%%&&%%%%%%%%%%%%%%%%%%%%%%%&%%%
%%%%%%%%%%%%%%#%%%%#%%%%%%%%%%%%%%%%#(######%%%####%%%%%%%%#%%%#%&%&&&&&&&&&&&%%%/%&&&%%%&&&&&%%%%%/%%%%%%%&&%%%&&&&%%%%
%%%%%%#%%##%#%%#%%%%##%%#%(#%#(##%%%#(((((##%%%%#####%%%%%%%%%%%%((#((%%%%%%//%&&&&%&&%&&&&&&%(%%%#%%%%%%&&&&&&%%%%%%%%%
(#%%%%%#####(##(#((((((((((((((#%%%%%##(##%%%%%#((###(##((((((#%%%%%%%%###%%##%%%%&&&&&&&&&&%%%%%%%#/%%&&&&&&&&&&&&&%%%%
((#((((#(#((((#(((/((((((((((((%%%%%%%%%%%%%%%/(/(((((/(//(/(((%%%%%&&&&&&&&&&&&&%%%%%((#########%(((%%&&&&&&%%&&%%%%%%%
###(##(###(######((##(###(##(#%%%%%%%%%%%%%%%%/((((/((((####%%%%%%%%/(////(////(//(((((((((((((((/%%%&&&&&&&&&&&%%%%%%%%
#####%###############(###(((#%%%%%%%%%&&%%%%%%//(#///(/((((((#/(/(((/((((((/((/((////(///(/(((//#%&&&&&&&&&&&&&&&&&&%&%%
%%%%%%%%%%%#%%#%####%######(%%%%%%%%%%%%%%%%%/((#(((/((//(/((/(((((((/(/((###(((#///((((((((#%%&&&&&&&&&&&&&&&&&&&&&&&%%";
        string _64 = @"
********************************,,,,,,,,,*//*,,,,**,,,,,,,,,,,,,,****,,,,,,*****,,**************************************
******************,******,,,,**********,,,,,,,,.,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************
********************,,*****,***,,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****
*,,**********,,**,,,,,,..,,,.,,,,,********,,,,,,,,,,,,,,,,,,,............,,.........,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
#####(,,,,,,,,,,,,,....,..,......,,,,..,,,,,,,,,,,........,,,,,.........................................,,,,,,,,,,,,,,,,
###########%%%(,................................................................................................,,,,,,,,
########%%%%%%%%%%%%(.............................................................,#(**.................................
#######%%%%%%%%%%%%%%%%%%,...................................................%&&&&&&&&&&%%*.............................
###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#............................... ........../%&&&&&&&&&&%%%%#............................
%%%##%%%%%%%%%%%%%%%%%%&&&&%%%%%%%%%%%%*........................     ......*%&&&&&&&&&%%%###(/..........................
%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&%&%%%%%%%%&&&&&&&%(/(((((//*               ../%%&&&&&&&%%%%##(/*,.........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%%%%&&&&&&&&&&&&%*/(((((((((((//,      ..,%&&&&&&%%%%%##((//*,........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%#&&&&&&&&&&&&&&(,####%%%%%%%#######((((/(&&%&&&%%%%%%%###(///*//((((,*,.............
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&%%%%%#&&&&&&&&&&&&&%%//#%%%#####%%%%%%%%%######%%&&&%%%%%%%%%######(##(######(,****,,,*///
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%&&#(&&&&&&&&&&&&%%%/%&&%%###%%%%%%%%##%%%######,%%(%%%%%%%%%%%################/*((((((((
%%#########%%%%%%%%%%%%%%%&&&%&&%%%#&&&&&&&&&&%%*,,/%&%%&&%%%%&&&%%#&&%%%%%%%%%%(.(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/#####
%%%%%%%%%%%%%%%%%%%%&%%%&%&&%&&&&&%&&&&&&&&%%*(/*/,,#%&&&&&&&&&&&&&%(%%&&%%&&&%%%*/#%&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%####
%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%&%%&&&&&&&&%%%%#,*/*/%&&&&&&&&&&&&&&&&&&&&&&&&&&&#/(/%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/
%%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%%%&&&&#&%%%%%%%%%%#((&&&&&&&&&&&&&&&&&&&&&%%&&&&&&%%#&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&%##%%%%%%%%%%%%%%/%&&&&&%#%%%%&&&&&&&&&%%%&&&&(%&&&%%&&&&%%%%%%%%%%%%%%%%%%%%%%%&%%%
%%%%%%%%%%%%%%#%%%%#%%%%%%%%%%%%%%%%#(######%%%#(#%%%%%%%%%#%%%#%&&&&&&&&&&&&%%%%/%&&&&%%&&&&%%%%%%/%%%%%%%&&%%%&&&&&%%%
%%%%%%%%%##%#%%(%%%%#%#%#%##%####%%%#((((###%%%%#####%%%%%%%%%%%#/(((#%%%%%%(/%&&&&%&&%&&&&&&&(%%%%%%%%%%&&&&&&%%%%%%%%%
(%%%%#%#####(##(#((((((##(((((((%%%%%###(#%%%%%#((#(#(##((((((#%%%%%%%%##%%%%##%%%&&&&&&&&&&%%%%%%%#(%%&&&&&&&&&&&&&%%%%
((((((((((((((#(((/((((///(((((#%%%%%%%%%%%%%%/(/(((((((//(/(((%%%%%&&&&&&&&&&&&&&&&&%###########%#(/%%&&&&&&&&&&&%%%%%%
######(#######(##((##(######(#%%%%%%%%%%%%%%%%/((((/((((#####%%%%%%%(////((///(((/(((((((((((((((/%%%&&&&&&&&&&&%%%%%%%%
#####%##########(####(###(((#%%%%%%%%%&&%%%%%%///(///(/((((#(((#(/((/((((((/((((/////((//(/((((/%%&&&&&&&&&&&&&&&&&&&&%%
%%%%%%%%%#%%%%#%####%######(%%%%%%%%%%%%%%%%%(((#(((/((/((//(((((((((/(/((#((/((#///(/(((((((%%&&&&&&&&&&&&&&&&&&&&&&&&%";
        string _65 = @"
*******************************,,,,,,,,,,*//*,,,***,,,,,,,,,,,,,,,**,,,,,*********,,,,,,,*******************************
******************,******,,,***********,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
*******************,,******,,**,,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
,,,**********,,**,,,,,,.,,,,.,,,,,********,,.,,,,,,,,,,,,,,,,.,........,.,,.....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
#####*,,,,,,,,,,,,,....,,,,......,,,,..,,,,,,,,,,,........,,,,,.......................................,,,,,,,,,,,,,,,,,,
###########%%#*,...............................................................................................,,,,,,,,,
#######%%%%%%%%%%%%%/.............................................................,/*,..................................
#######%%%%%%%%%%%%%%%%%%....................................................%&&&&&&&&&%%%..............................
###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#............................... ........../&&&&&&&&&&&%%%%#............................
%%%##%%%%%%%%%%%%%%%%%%&&&&%%%%%%%%%%%#..................     ....   ....../%&&&&&&&&&%%%###(*..........................
%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%%%&&&&&&&&%//((((//,               ..*%&&&&&&&%%%%%##(/*,.........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%%%%&&&&&&&&&&&&&(*(((((((((((//.      .*%%%&&&&&%%%%%##((/**,........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%&&&&&&&&&&&&&&%./###%%%%%%#######(((((/(&&%&&&%%%%%%%###((//*//((((./,.............
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%%%%%%%#&&&&&&&&&&&&&%//(%%%####%%%%%%%%%%%#####%%&&&%%%%%%%%%######(##(######(*****,,,,*//
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%&%&&%#%&&&&&&&&&&&%%%/#&&%#(##%%%%%%%%#%%%%#####(/%#(%%%%%%%%%%%################*/((((((((
%##########%%%%%%%%%%%%%%&&&&%&&&%%#&&&&&&&&&&%%%,,*#%%&&&%%%%%%&%%#%%%%%%%%%%%%(.(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/#####
%%%%%%%%%%%%%%%%%%%%%%%&&%&&%&&&&&%&&&&&&&&%%#(///*,/%&&&&&&&&&&&&&##%%&&%&&&%%%%*##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%####
%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%&&%&&&&&&&&%%%%%*////(&&&&&&&&&&&&&&&&&&&&&&&&&&&#/#(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%/
%%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%%%%&&&%%%%%%%%%%%%#(/#&&&&&&&&&&&&&&&&&&&&%%&&&&&&%%%&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&##%%%%%%%%%%%%%%((&&&&&&%%###&&&&&&&&%%%%&&&&(&&&&&%&&&&%%%%%%%%%%%%%%%%%%%%%%%&%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%(((#####%%%/##%%%%%%%%##%%%%%%&&&&&&&&&&%%%%(%&&&&%%&&&&%%%&%%(%%%%%%%&&%%%&&&&&%%%
#%#%##%%%##%%%#(%%%#%%#%%#######%%%%%#((((##%%%%##%%#%%%%%%%%%%%%/(//#%%%%%%%/%%&&&&&&%&&&&&&&%#%%(%%%%%%%&&&&&%%%%%%%%%
(%#%%#%########((((((((##(((((((#%%%%%##(##%%%%%((#(####(##(((#%%%%%%%%#(#%%%%%#%%%&&&&&&&&&&%#%%%%%(%%%&&&&&&&&&&&&%%%%
((((((#(((((((((((((((((/((((((#%%%%%%%%%%%%%%%//(((((((//(((((#%%%%%%&&&&&&&&&&&&&&&&&%%###%##%%###/(%%&&&&&&&&&&%%%%%%
#####(###(#######((#####(%####%%%%%%%%%%%%%%%%(/((((((((###%%%%%%%%%#(///((///(((/((((((((((((((((#%%&&&&&&&&&&&%%%%%%%%
######################((#((((%%%%%%%%%%&&%%%%%///(///(/#(#(#((##%(((/((((((/((((///(//(//(/((/((#%%%&&&&&&&&&&&&&&&&&&%%
%%%%%%%%%%%%%%%%#%##%#####((#%%%%%%%%%%%%%%%%#/#((/((/(/((//((((((((((((((((//(((///(/(((((((#%%&&&&&&&&&&&&&&&&&&&&&&&%";
        string _66 = @"
*******************************,,,,,,,,,,*//*,,,***,,,,,,,,,,,,,,,**,,,,,*********,,************************************
******************,******,,,***********,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
*******************,,******,,**,,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
,,,**********,,**,,,,,,.,,,,.,,,,,********,,.,,,,,,,,,,,,,,,,.,........,.,,.....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
#####*,,,,,,,,,,,,,....,,,,......,,,,..,,,,,,,,,,,........,,,,,.......................................,,,,,,,,,,,,,,,,,,
###########%%#*,...............................................................................................,,,,,,,,,
#######%%%%%%%%%%%%%(.............................................................,,,...................................
#######%%%%%%%%%%%%%%%%%%....................................................#&&&&&&&&&%%%..............................
###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#............................... ..........(&&&&&&&&&&&%%%%#............................
%%%##%%%%%%%%%%%%%%%%%%&&&&%%%%%%%%%%%#..................     ....   ....../%&&&&&&&&%%%%###(*..........................
%%%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%%%%%%%%%&&&&&&&&&#//(((//,               ..,%&&&&&&&%%%%%##(/*,.........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%%%%%&&&&&&&&&&&&&*/((((((((((//.      ./%%&&&&&&%%%%%##((/*,.........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%#&&&&&&&&&&&&&&(,###%%%%%%#######(((((/(&&%&&&%%%%%%###(////*//(/((,/,.............
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%%%%%%%(&&&&&&&&&&&&&%%/(%%%####%%%%%%%%%%%#####%%&&&%%%%%%%%%######(##(######//****,,,,*//
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%&&&##&&&&&&&&&&&%%%%/&&%#(##%%%%%%%%#%%%%#####/(%/*%%%%%%%%%%#################*//(((((((
%%#########%%%%%%%%%%%%%%%&&&%&&&%%#&&&&&&&&&&&%%(,*(%%%&&%%%%%%&%%#%%%%%%%%%%%%#./%&%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/#####
%%%%%%%%%%%%%%%%%%%%%%%&&%&&%&&&&&%&&&&&&&&&%%(#*(*,,##&&&&&&&&&&&&##%%&&%&&&%%%%*##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#(##
%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%&&%&&&&&&&&&%%%%#///*/%&&&&&&&&&&&&&&&&&&&&&&&&&&####%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(
%%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%%%%&&&&#&%%%%%%%%%%#(/%&&&&&&&&&&&&&&&&&&&%%&&&&&&%%%&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%##%%%%%%%%%%%%%%/&&&&&&&%#%#%%&&&&&&%%%%&&&&(&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%#(#(#####%%##(%%%%%%%%%#%%%%%%%&&&&&&&&&%%%%#%&&&&%%&&%%%%%%%%%%%%%%%%&&%%%&&&&&%%%
#%#%%#%%%##%%%#(%%%#%%#%%#######%%%%%#((((###%%%%%%%#%%%%%%%%%%%%/(/(#%%%%%%%##%&&&&&&%&&&&&&&&(%%#%%%%%%%&&&&&&%%&&%%%%
(%#%%#%########(#((((((##(((((((#%%%%%###(##%%%%((#(####(##(((#%%%%%%%%%#(%%%&&&%#%%&&&&&&&&&&#%%%#%(%%%&&&&&&&&&&&&%%%%
((((((#(((((#(((((((((((/(((((((%%%%%%%%%%%%%%%(/(((((((//(((((#%%%%%%%&&%&&&&&&&&&&&&&&%(###%#%%#%(#/%%&&&&&&&&&&%%%%%%
#####(###(#######((####((#%###%%%%%%%%%%%%%%%%%*(#((((((###%#%%%%%%%%((//(((//(((/(((((((((((((((#(%%&&&&&&&&&&&%%%%%%%%
######################(((((((#%%%%%%%%%%&&%%%%%/((///(/#(#(#(#%%%(((/((((((/((((///(//(//(/((/((/%%%&&&&&&&&&&&&&&&&&&%%
%%%%%%%%%%%%%%%##%########(#(%%%%%%%%%%%%%%%%(/#((/((/(/((//((((((((((((((((//(((///(/((((((((#%&&&&&&&&&&&&&&&&&&&&&&&%";
        string _67 = @"
*******************************,,,,,,,,,,*//*,,,***,,,,,,,,,,,,,,,***,**************************************************
******************,*******,,***********,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
********************,******,,**,,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
,,,**********,***,,,,,,.,,,,.,,,,,********,,.,,,,,,,,,,,,,,,,.,........,.,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
#####/,,,,,,,,,,,,,....,,,,......,,,,..,,,,,,,,,,,........,,,,,.......................................,,,,,,,,,,,,,,,,,,
###########%%#/,...............................................................................................,,,,,,,,,
#######%%%%%%%%%%%%%(.............................................................,.....................................
#######%%%%%%%%%%%%%%%%%%,...................................................*%&&&&&&&&%%#..............................
###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#,.........................................(&&&&&&&&&%%%%%#(............................
%%%##%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%%%#,.................     ....   ....../%&&&&&&&%%%%%#(((,..........................
%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%%%%%%%%%%%&&&&&&&&%(//((//,               ..,%&&&&&&&%%%%##(/*,..........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%%%%%&&&&&&&&&&&&&(*((((((((((//.      ./%%&%%%%%%%%%##((//*,.........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%&%#&&&&&&&&&&&&&&%./##%%%%%%#######(((((/%&&%&%%%%%%%####(//*/*////((,/,.............
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%%%%%%%#&&&&&&&&&&&&&%%/((%%#####%%%%%%%%%%#####%%&&%%%%%%%%%####(((((((##(((#*/,***,,,,*//
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%&&%%#&&&&&&&&&&&&%%%#(&%#(##%%%%%%%%#%%%%#####/(#,(%%%%%%%%%##################*//(((((((
%%########%%%%%%%%%%%%%%%%&&&%&&&%%#%&&&&&&&&&&&%%,,,#%&&&%%%%&%&%%#%%%%%%%%%%%%(.(%%%%%%%%%%%%#####%%#%%%%%%%%%%#/#####
%%%%%%%%%%%%%%%%%%%%%%%&&%&&%&&&&&&&&&&&&&&&%%&(///*,/%%&&&&&&&&&&&%#%%&&%&&&%%%%*##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#(##
%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%&&%&&&&&&&&&%%%%%/##/*/&&&&&&&&&&&&&&&&&&&&&&&&&&%#%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(
%%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%%%%&&&&%&%%%%%%%%%%##/(%&&&&&&&&&&&&&&&&&&%%&&&&&&%#%&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%&&&%##%%%%%%%%%%%%%%*&&&&&&&&%%%##%&&&&&%%%%&&&&%%&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%
%%%%%%%%%%%%%#%%%%%%%%%%%%%%#%%%%%%%%%(((#####%%%%(%%%%%%%%#/%%%%%%%%%&&&&&&&%%%%%%&&%&%(%%%%%%%%%%%&%%%%%%%%%%%%%&&&%%%
%%%%%#%%##%#%%##%%%%%%##%(%%####%%%%%%#((((###%%%%%%%#%%%%%%%%%%%/((%%%%%%%%%%*%&&&&&&&%%%%%%%%%%%%%%%%%%%%&&&&&&%&&%%%%
(##%%#%########(#((((((#((((((((##%%%%%###(#%%%%#(#(####(###((#%%%%%%%%%%##%%&&&&%%%%&&&&&&&&&%(%%%%/%%%%&&&&&&&&&&&%%%%
((((((#(((((##((((((((((((((((((#%%%%%%%%%%%%%%%*(((((((//((##(%%%%%%%%%%%%%%%%%&&&&&&&&&&%####%%%(##/%%%&&&&&&&&&%%%%%%
################(((#(##(###(#%#%%%%%%%%%%%%%%%%/((((((((###%%#%%%%%%%#%&%#((//(((/(((((((((((((((((#%%%&&&&&&&&&%%%%%%%%
####################(#####((#(%%%%%%%%%%%&&%%%#*((/(/(/###(#%#%%%#((((((((((#(((///(//(/((//(/((((%%%&&&&&&&&&&&&&&&&&&%
#%%%%%%%%%%%%#%####%####(((##(%%%%%%%%%%%%%%%%(#((////((#(///(((((((((((((((//((////(/((/#(((#((%&&&&&&&&&&&&&&&&&&&&&&&";
        string _68 = @"
*******************************,,,,,,,,,,*//*,,,***,,,,,,,,,,,,,,,***,**************************************************
******************,*******,,***********,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
********************,******,,**,,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
,************,***,,,,,,.,,,,.,,,,,********,,.,,,,,,,,,,,,,,,,.,........,.,,.....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
#####*,,,,,,,,,,,,,....,,,,......,,,,..,,,,,,,,,,,........,,,,,.......................................,,,,,,,,,,,,,,,,,,
###########%%#/,.............................................................................................,,,,,,,,,,,
#######%%%%%%%%%%%%%*...................................................................................................
#######%%%%%%%%%%%%%%%%%%.....................................................#&&&&&&%%%%,..............................
###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(,.........................................#&&&&&&&&%%%%%##,............................
%%%##%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%%%#..................       ..   ......(%%%%%%%%%%%##(((/...........................
%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%%%%%%%%%%%&&&&&&&&%(//((//,               ..*%%%%%%%%%%##((/*,,..........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%%%%#&&&&&&&&&&&&&%,/(((((((((//.      .*%%%%%%%%%%%##(//**,..........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%&%%&&&&&&&&&&&&&&%/,##%%%%%%#######(((((/%%%%%%%%%####(((/*********////..............
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%%%%%%%%%&&&&&&&&&&&&&%%/(#%####%%%%%%%%%#######%%%%%%%%%####((((/(//(/(((((((**,***,,,,///
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%&&%%#&&&&&&&&&&&&%%%%/%%#(##%%%%%%%%#%%%######(%(/#%%%%%######(((((#((########*//(((((((
%%########%%%%%%%%%%%%%%%&&&&%&&%%%%%&&&&&&&&&&&%%(,,(%&&&%%%%&%&%%%%%%%%%%%%%%(,*%%%%%%%%##################%%%%##/#(###
%%%%%%%%%%%%%%%%%%%%%%%&&&&&%&&&&&&&%&&&&&&&&&&##*(*,,%#&&&&&&&&&&&%#%%&&%&%&%%%%/##%%%%%%%%%%#####%###%%%%%%%%%%%%%####
%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%&&%&&&&&&&&&&%%%%###%**(&&&&&&&&&&&&&&&&&&&&&&&&%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(
%%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%%%%&&&&%%%%%%%%%%%%#(//#&&&&&&&&&&&&&&&&&&%&&&&&%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%&&&&%#%%%%%%%%%%%%%%,&&&&&&&&&%%%##&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(#(#####%%%%%%%%%%%%%/#%%%%%%%%%%&&&&&&%%%%%%%%%%%#%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%
%#%%##%%##%%%%#%##%%%%##%(#%%##%%%%#%%#((((###%%%%%%%%%%%%%%%%%%#(((%%%%%%%%%%#%%&&%%%%#(%%%%%%%(%%%%%%%%%%%%%%%%%%%%%%%
#%#%%%#####(###(#((((((#(((((((((#%%%%%#((((#%%%%/#((###((#((%%%%%%%%%%%%#(%%&&&&&%%%%&%%%%%%%%%%%%%%%%%%%&&&%%%%%%%%%%%
(((((((((((#(((((/((((((/((((((((%%%%%%%%%%%%%%%#((((((///((%%#%%%%%%%%%%%%###%%%%%%&&&&&&&&###%%%(%(#%%&&&%%%%%%%%%%%%%
####((#######(##((##(##(%####%##%%%%%%%%%%%%%%%#*(((/(((##%%##%%%%%%%%&&&&&&&&%%#((((((((#((((((((#%*%%%%%%%%%%%%%%%%%%%
##############(#########(#/(((#%%%%%%%%%%%&%%%%#(///((/(/(##(%%%%#((((((((((#(((//((((//(/(((((((*#%%%%&&&&&&&&&%%%%&&&%
%%%%%%%%%%%%%%##%#%#####(#((((%%%%%%%%%%%%%%%%#/(((////((////(((((((/(((((((//(#////(/((/#(((#((/&%&&&&&&&&&&&&&&&&&&&&&";
        string _69 = @"
*******************************,,,,,,,,,,//*,,,,***,,,,,,,,,,,,,,*******************************************************
******************,******,,,***********,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
*******************,,**********,,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
,************,***,,,,,,.,,,,,,,,,*********,,.,.,,,,,,,,,,,,,,,........,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
#####,,,,,,,,,,,,,,...,,.,,,.....,,*,..,,,,,,,,,,,........,,,,........................................,,,,,,,,,,,,,,,,,,
########%#%%%#*..............................................................................................,,,,,,,,,,,
#######%%%%%%%%%%%%%,...................................................................................................
#######%%%%%%%%%%%%%%%%%(....................................................../#%%%%%%#,...............................
####%%%%%%%%%%%%%%%%%%%%%%%%%%%%*..........................................*%%%%%%%%%%%##(/.............................
%%%##%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%%%(.......................       ......%%%%%%%%%###(///*,...........................
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%%%%&&&&&&&%///////.               ..%%%%%%%%###((//*,,...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%%%&&&&&&&&&&&&&(/(((((((((/*.      . %%%%%%%####((/**,............................
%%%%%%%%%%%%%%%%%%%%%%%%%#%#%%%%%%%%%%%&&&&&&&&&&&&&&%,/##%###########(((((#%%%%%%###((((/***,,,,,,*,**//,..............
%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%(&&&&&&&&&&&&&%%#//#####################%#########((((///*/**/*////////,.,,,...,///
%%%%%%%%%%%%%%%%%%###%%%%#%%&&&&&&%%##&&&&&&&&&&&%%%%#(#####%%%%%%%#########(#%%%########(((((((//((/((((((((*///////(((
%###########%%%%%#%%%%#%%%&&&%&&%%%%#%&&&&&&&&&&&%%#**(%%&%%%%%%%%#%%%%%%%%%%##,(##%#########((((((((((##########((((((#
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%&%%%&&&&&&&&&&&%%%(/,,%#%&&%%%%&&%%%%%%%%%%%%%%####%%########################%#####(###
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%&&&&&&&%%%#//#%/**(%&&&&&&&%%%%%%%%%%%%%%%%%###%%%##%%################%%%%%%%%%%%#(
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%%%%%%#/((#/(%&&&&&&&&&&&%%%%%%%%%%%%%#%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%
###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#&&&%#%%%%%%%%%%%%#/*/%%&%%%&%%%&%&&&&&%%%%%%%%(%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%#%%%%%%%%%%%%%%#%%%%%%%%%%#((##%%%##%%%%%%%%(((###((#####%%%%%%%%%%%#%%%%%%%##%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%
%%%##%%####%%#(%%%%%%%#%#%##%%#%%%%##%%((((####%%%%%%%%%%%%%%%###%((%%%%%%%%%%#%%%%%%%####%%%%%%%#%(%%%%%%%%%%%%%%%%%%%%
##%%#%########(((#((((###((((((##(#%%%%#(((((##%%%/#(##(((#%%%%%%%%%%##%(*(%%%%%%%%%%(#%%%%%%%%%##%/%%%%%%%%%%%%%%%%%%%%
(((((((((((#(((((//((((/(((((((//#%%%%%%####%%%%%*/(#(((/(/%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##%##(%%%%%%%%%%%%%%%%%%%
#########(##(##(((#(##(#####%####%%%%%%%%%%%%%%%#//(/((###########%%%%%%%%%%%%%%%%%%%%%%###((((((##(*(%%%%%%%%%%%%%%%%%%
#####################(###((((((#%%%%%%%%%%%%%%%#(///(/((#####%##%#(((((/((((((((//(/((//(/((((((((/(%%%&%%%%%%%%%%%%%%%%
%%%%%%##%%%#######%###((##(#((#%%%%%%%%%%%%%%%%(((/////#(///((((((((///(((#//(((////(((/(((((((((*(%&&&&&&&&&%%%%%%%%%%%";
        string _7 = @"
****************************/////////////////////////((((((((((((((((((#########################################%%%%%%%%
,,,*******************************/////////////////////////////((((((((((((((((((((((((#################################
,,,,,,,,,,,,,,,,,,,,*************************************//////////////////((((((((((((((((((((((((((((#################
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**********************************///////////////////////(((((((((((((((((((((((((((((((((
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************///////////////////////////////((((((((((((((((((((
.........,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************************//////////////////////////////(((((((((
...........................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****************************///////////////////////////////
......................................,,,,,,,,,,,,/%%/,,,,,,,,,,,,,*******************************//////////////////////
#####(,......................................,,,%&&&&&&&/,,,,,,,,,,,,,,,,,,,*********************************///////////
############%%/..............................,*%&&&&&&&&&#,,,,,,,,,,,,,,,,,,,,,,**********************************//////
#######%%%%%%%%%%%%%%%%%%%%..................(#%&&&&&&&&/,,,,,,,,,,,,,,,,,,,,,,,,,**************************************
%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%#*........,//%&&&&&&&%,...,,,,,,,,,,,,,,,,,,,,,,,,,,,**********************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%////&&&&&&&&&&.....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************
##%%%%%%%########%%%%%%%%%%&&&%&%%%%%%%%/(*#&&&&&&&&&&&%%%%%%%%%/,,,,,,,,,,,,,,,****************************************
#############%%%#%%%##########%%%%%%%###**(&&&&&&&&&&&&###%%%%&&&&&&&&&&&&&&%%%%%##(//**********************************
###############################%%%%%%%%%**#&&&&&&&&&&&%####%%%%%%&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%#/*///***////
####%%%%%%%##%##########################*/%&&&&&&&&&&&&%%%%%&&&&%%%###%%%%%%&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&(
%%%%%%%%######%########################,*%%&&&&&&&&&&&&##/(&@&&&####%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%####%%%#%%#######%##%###%%%%%%%%#,*(&&&&&&&&&&&&&&&*/%&&@@@%%%################%####%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&
%%%%%%%%%%%%%%%%%%%%%%%%%%%###%%%#%%**/%&&&&&&&&&&&&&&&%#(#&&&&&&&&&%%%%%%##%%%###########%#%#######%%%%%%%%%%%%%%%%%%%%
########%#%#####%########%%###%%%%%**(%&&&&&&&&&&&&&&&&%(/*#&&&&&&%&&&&&&%%%%%%%&#%%%%%%%&&&&&&&%###%#######%%%%%%%%%%%%
((((#((((((((((((((((((/(((((((((((((%&&&&&&&&&&&&&&(&&&&%%%#&&&&&%%%#%&&%%%%%&&&%%%%%%%%#%&&%#%%%%#%%%%%###%##%%%%%%###
#######(###%####(############(#(((((%%&&&&&&&&&&&&&&%%%(#(%%%%&&&&&%#(((#(######(#####(##(((((####(#########((#########%
#####################%#######(##%#%##(&&&&&&&&&&&&&&&##%#%&#%%%%%%%%###(#########(########%#%%###########%%##%%%%%#%#%#%
#%%%%%%%%###########((############(&%(&&&&&&&&&&&&%&&%####/%%%%%%%%%%###((####(#%%%%%%%################################%
&%%%%&&%&%%%%%%####(##%#(###((####%&##&&&&&&&&&&&&&&&%######%%%%%%%%%###%#%%%%%&&%%%%%%%%%%#%###%%###%%##%######%#%###%%
&&&&&&&&&&&&&&&&%%###%%%&&%%%%###/&&%&&&&&&&&&&&&&&&&&####(/%%%&%%%%%%%&%%%%#%%%%%#%%%#%%%#%%%%#%%%%#%%%#%%%%%%%%%%%#%##";
        string _70 = @"
*******************************,,,,,,,,,,//*,,,,***,,,,,,,,,,,,,,*******************************************************
******************,******,,,***********,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
*******************,,**********,,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
,************,***,,,,,,.,,,,,,,,,*********,,.,.,,,,,,,,,,,,,,,........,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
#####,,,,,,,,,,,,,,...,,.,,,.....,,*,..,,,,,,,,,,,........,,,,........................................,,,,,,,,,,,,,,,,,,
########%#%%%#*..............................................................................................,,,,,,,,,,,
#######%%%%%%%%%%%%%,...................................................................................................
#######%%%%%%%%%%%%%%%%%(....................................................../#%%%%%%#,...............................
####%%%%%%%%%%%%%%%%%%%%%%%%%%%%*..........................................*%%%%%%%%%%%##(/.............................
%%%##%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%%%(..................            ......%%%%%%%%%###(///*,...........................
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%%%%&&&&&&&%///////.               ..%%%%%%%%###((//*,,...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%%%&&&&&&&&&&&&&(/(((((((((/*.      . %%%%%%%####((/**,............................
%%%%%%%%%%%%%%%%%%%%%%%%%#%#%%%%%%%%%%%&&&&&&&&&&&&&&%,/##%###########(((((#%%%%%%###((((/***,,,,,,*,**//,..............
%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%(&&&&&&&&&&&&&%%#//#####################%#########((((///*/**/*////////,.,,,...,///
%%%%%%%%%%%%%%%%%%###%%%%#%%&&&&&&%%##&&&&&&&&&&&%%%%#(#####%%%%%%%#########(#%%%########(((((((//((/((((((((*///////(((
%###########%%%%%#%%%%#%%%&&&%&&%%%%#%&&&&&&&&&&&%%#**(%%&%%%%%%%%#%%%%%%%%%%##,(##%#########((((((((((##########((((((#
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%&%%%&&&&&&&&&&&%%%(/,,%#%&&%%%%&&%%%%%%%%%%%%%%####%%########################%#####(###
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%&&&&&&&%%%#//#%/**(%&&&&&&&%%%%%%%%%%%%%%%%%###%%%##%%################%%%%%%%%%%%#(
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%%%%%%#/((#/(%&&&&&&&&&&&%%%%%%%%%%%%%#%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%
###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#&&&%#%%%%%%%%%%%%#/*/%%&%%%&%%%&%&&&&&%%%%%%%%(%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%#%%%%%%%%%%%%%%#%%%%%%%%%%#((##%%%##%%%%%%%%(((###((#####%%%%#%%%%%%#%%%%%%%##%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%
%%%##%%####%%#(%%%%%%%#%#%##%%#%%%%##%%((((####%%%%%%%%%%%%%%%###%((%%%%%%%%%%#%%%%%%%####%%%%%%%#%(%%%%%%%%%%%%%%%%%%%%
##%%#%########(((#((((###((((((##(#%%%%#(((((##%%%/#(##(((#%%%%%%%%%%##%(*(%%%%%%%%%%(#%%%%%%%%%##%/%%%%%%%%%%%%%%%%%%%%
(((((((((((#(((((//((((/(((((((//#%%%%%%####%%%%%*/(#(((/(/#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##%##(%%%%%%%%%%%%%%%%%%%
#########(##(##(((#(##(#####%####%%%%%%%%%%%%%%%#//(/((###########%%%%%%%%%%%%%%%%%%%%%%###((((((##(*(%%%%%%%%%%%%%%%%%%
#####################(###((((((#%%%%%%%%%%%%%%%#(///(/((#####%##%#(((((/((((((((//(/((//(/((((((((/(%%%&%%%%%%%%%%%%%%%%
%%%%%%##%%%#######%###((##(#((#%%%%%%%%%%%%%%%%(((/////#(///((((((((///(((#//(((////(((/(((((((((*(%&&&&&&&&&%%%%%%%%%%%";
        string _71 = @"
*******************************,,,,,,,,,,//*,,,,***,,,,,,,,,,,,,,*******************************************************
*************************,,,***********,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
*******************,,*******,**,,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
,************,***,,,,,,.,,,,.,,,,*********,,.,.,,,,,,,,,,,,,,,........,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
#####*,,,,,,,,,,,,,...,,..,,.....,,,,.,,,,,,,,,,,,........,,,,........................................,,,,,,,,,,,,,,,,,,
##########%%%%*..............................................................................................,,,,,,,,,,,
#######%%%%%%%%%%%%%,...................................................................................................
#######%%%%%%%%%%%%%%%%%(......................................................,*(%%%%#*................................
####%%%%%%%%%%%%%%%%%%%%%%%%%%%%/..........................................,%%%%%%%%%###((*.............................
%%%##%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%%%# .................  .....    ......,#%%%%%%%####(/***............................
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%%%%%&&&&&&%*//////.               .,%%%%%%%####((/*,,............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%%%%&&&&&&&&&&&&#*(((((((((/*.      ..%%%%%%####((//*,,............................
%%%%%%%%%%%%%%%%%%%%%%%%%#%#%%%%%%%%%%#&&&&&&&&&&&&&&%(,###%##########(((((#%%%%####((((/***,,,,.,,,,****...............
%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%%&&&&&&&&&&&&&&%%/*#####################%#######(((((///*******//////*/,.,,,...,///
%%%%%%%%%%%%%%%%%%######%#%%&&&&&&%%#(&&&&&&&&&&&&%%%%(#####%#%%%%%########(#%%%%#######(((((////////((((((((,///////(((
%###########%%%%%#%%%%#%%%&&%%&&%%%%#%&&&&&&&&&&&%%%%,/%&&%%%%%%%%#%%%%%%%%%%##,##(#######(((((((((((((((#######(/(((((#
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%&%%%&&&&&&&&&&&&%%#/*,%%#%%%%%%%%%%%%%%%%%%%%#%####%##########(((##################((##
%#%%%%%%%%%%%%%%###%%%%%%%%%%%%%%%%&%&&&&&&&&#%(((##(*,,#&&&&&&%%%%%%%%%%%%%%%%%%###%%%#####################%%%%%%%%%%#(
##%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%%%%%##*#%(%/%&&&&&&&&&%%%%%%%%%%%%%%%(##%%%%#%%##############%%%%%%%%%%%%%%%
###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(&&&%#%%%%%%%%%%%%#*/,%%%%%%%%%%&%%%&&&%%%%%%%%#%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%#%%%%%%%%%%%%%%#%%%%%%%%%&%#(#%%%%%#%%%%%%%%*(##((///(((##%%%(%%%%%%(%%%%%%%%(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
#%%##%%###%%%##%%%%%%##%(%%#%###%%%##%%((((#####%%%#%%%%%%%%%%((#%%#%%%%%%%%%%(%%%%%%%(%%(%%%%%%%/%(%%%%%%%%%%%%%%%%%%%%
##%%#%########(#(#((((#((((((((##((%%%%#(((((##%%%(((##((#%%%%%%%%%%%(##/*(%%%%%%%%%%((#%%%%%%%%%#%/%%%%%%%%%%%%%%%%%%%%
((((((((((((((((//(((((((((((((//(%%%%%%##(###%%%%/((((/((/%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%%%%%%%%#%###%%%%%%%%%%%%%%%%%%%
#########(##(##((##(##(#####%#####%%%%%%%%%%%%%%%*///(/##########%%%%%%%%%%%%%%%%%%%%%%%%%#((((((###/#%%%%%%%%%%%%%%%%%%
%############(###########((((((##%%%%%%%%%%%%%%%(/(/(/(/%##(%###%((((((/((((((((//(/((//(/(((((((((/%%%%%%%%%%%%%%%%%%%%
%%%%#%#%%%#%###%#%####((##((((#%%%%%%%%%%%%%%%%%/(////(#////(((((/((//((/((//(((/////((/(((((((((*/#&&&&&&&&&%%%%%%%%%%%";
        string _72 = @"
*******************************,,,,,,,,,,//*,,*,***,,,,,,,,,,,,,,*******************************************************
*************************,,,***********,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
*******************,,*******,**,,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
,,***********,,*,,,,,,,.,,,,,,,,,*********,,.,.,,,,,,,,,,,,,,,........,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
#####/,,,,,,,,,,,,,...,,..,,.....,,*,.,,,,,,,,,,,,........,,,,........................................,,,,,,,,,,,,,,,,,,
##########%%%%*..............................................................................................,,,,,,,,,,,
#######%%%%%%%%%%%%%....................................................................................................
#######%%%%%%%%%%%%%%%%%(........................................................*##((*.................................
####%%%%%%%%%%%%%%%%%%%%%%%%%%%%*...........................................(%%%%%%%####((..............................
%%%##%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%%%#..................     ..    ......,#%%%%%%%###(//***............................
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%%%%#%&&&&&%*//////.             ...,%%%%%%####((/**,,............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%%%%%&&&&&&&&&&%%*/((((((((/*.      ..%%%%%####(((/**,.............................
%%%%%%%%%%%%%%%%%%%%%%%%%#%#%%%%%%%%%%%%&&&&&&&&&&&&&&#,(############(((//#%%%%####(((///***,,.....,,***,...............
%%%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%%%%%%#&&&&&&&&&&&&&&%#,/##################(#########((((//*/*******/////***,.,,....,*//
%%%%%%%%%%%%%%%%%#######%#%%%%&&&&%%%(&&&&&&&&&&&&%%%%/(####%#%%%########((((##%#######(((((//////////(((((((,////////((
%###########%%#%%#%%%%#%%%%%%%&%%%%%%#&&&&&&&&&&&%%%%(/#&%%%%%%%%%#%%%%#%#####*((*(######((((((((((((((((((#####(*((((((
%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%&&%%&&&&&&&&&&&&%%%**,*%(%%%%%%%%%#%%%%%%%%%%##/##%%########(((((((##(#############/((#
#%#%%%%%%%%%%#######%%%%%%%%%%%%%%%%%%&&&&&&&%%%%(%#*/,,,%%%&&&%%%%%%%%%%%%%%%%%%###%%#######################%%%%%%%%##/
#####%%%%##%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%####/#%#%/#%%%&&&%%%%%%%%%%%%%%%%%#/##%%%%##%################%%%%%%%%%%%%%
###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%#%%%%%%%%%###(///%%%%%%%%%%%%&&&%%%%%%%%%#%%%%%%%#%%%%%%##%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%#(%%%%%%%%%%%%%#((#((##%%%%%%%%%##/%%%%%%#%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
#%%##%%#(#%##(%###%%%###(###%(##%%%##%%((((#####%%%%%%%%%%%%#/(####%%%%%%%%%%%(%%%%%%%(%%##%%%%%%%%#%%%%%%%%%%%%%%%%%%%%
###%%#%###(###(#((((((#(((((((((#((##%%#((((####%%%(###(%%%%%%%%%%%######//%%%%%%%%%%(%##%%%%%%%%#%(%%%%%%%%%%%%%%%%%%%%
((((((((((((((((/(/(((((((((((((/(#%%%%%#((((##%%%%(((((((/%%%%%%%%%%%%%%%%%%%%%%%%%(#%%%%%%%%%%%##(%#%%%%%%%%%%%%%%%%%%
###(####((#####(((#(########%##((#%%%%%%%%%%%%%%%%*/((/###(######%%%%%%%%%%%%%%%%%%%%%%%%%%%%(((#####%%%%%%%%%%%%%%%%%%%
%#############%#####(####(((((((#%%%%%%%%%%%%%%%#*(((/*##((######((((((#%%%%%%%%%#(/////((((((((((/#%%%%%%%%%%%%%%%%%%%%
%%%%%##%%########%###((##((((((#%%%%%%%%%%%%%%%%///////(///(((((/(((/((((((*/(((/(/((((/(/(/(((/(*##%%&&&&&&&%%%%%%%%%%%";
        string _73 = @"
*******************************,,,,,,,,,,//*,,*,***,,,,,,,,,,,,,********************************************************
*************************,,,***********,,,,,,,.,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
*******************,,*******,**,,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
**************,*,,,,,,,.,,,,,,,,,*********,,.,,,,,,,,,,,,,,,,,........,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
#####/,,,,,,,,,,,,,...,,.,,,.....,,*,.,,,,,,,,,,,,.......,,,,,........................................,,,,,,,,,,,,,,,,,,
##########%%%%*...............................................................................................,,,,,,,,,,
#########%%%%%%%%%%%....................................................................................................
#########%%%%%%%%%%%%%%%(........................................................,**,,..................................
####%%%%%%%%%%%%%%%%%%%%%%%%%%%%*...........................................*%%%%%%####((,..............................
%%###%%%%%%%%%%%%%%%%%%&&&&%%%%%%%%%%%# ................   .....       ...,#%%%%%####((/***,............................
%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%%%%%%%%%%%%###%#%#/*//////.             ...,%%%%%####((//**,.............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%%%%%%&&&&&&&&&%%*/((((((((/*.      ..#%%#####(((//**,.............................
%%%%%%%%%%%%%%%%%%%%%%%%%#%#%%%%%%%%%%%#%&&&&&&&&&&&&&%/*############(((//%%%#####(((////***,,.......,,,................
%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%%%&&&&&&&&&&&&&&%(*(################(/########((((//**********/**//,,,,.,,....,///
%%%%%%%%%%%%#%%%########%#%%%%&%%%%%%#%&&&&&&&&&&&&%%%#/((##%##%%#######(((((########((((((////////////////(/*////////((
############%%#%%#%%%##%%%%%%%%%%%%%%(%&&&&&&&&&&%%%%%#%%%%%%%%%%%######%#####(#//(#####((((((((((((((((((((###((*((((((
%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#&&&&&&&&&&&%%%#,,,###%%%%%%%%#%%%%%%%%%##(,###########(((((((((((#############/(((
###%%%%%#%%%%########%%%%%%%%%%%%%%%%%&&&&&&&&%%&##/*(*,*(%%%%%%%%%%%%%%%%%%%%%################################%##%%###/
###########%%##%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%###((#(%%(*(%%%%%%%%%%%%%%%%%%%%%%%*###%%######################%%%%%%%%%%%
####%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%&%%%%%%%%%%###%*#/#(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##############%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%#%%%%#%%%%%%%%%%%%%%%%%%%%%%%(%%%%%%%%%%%###*##(#%%%%%%%%%%%%%%%%%%%%%%%%%%%%###%%%%%#%%%%%%%%%%%%%%%%%%%%%%%
%%%%#%####%##(%###%#%###(####(#######%%#(((#######%%%%%%%%/(##########(###%%%%(#%%%%%%(%%#(%%%%%%%#%(%%%%%%%%%%%%%%%%%%%
###%%#####(#(#(#((((((##((((((((#(/(##%%(((((####%%%/##%%%%%%%%%##((###%##/#%%%%%%%%%(%%#/#%%%%%%%#(#%%%%%%%%%%%%%%%%%%%
((((((((((((((((///(/(((((((((/(/((#%%%%#(((((##%%%(((((/((%%%%%%%%%%##%%%%%%%%%%%%%(((%%%%%%%%%%##(%(%%%%%%%%%%%%%%%%%%
###(####(##(###((#(#(##(#######(((##%%%%%#####%%%%%/(((((#(######%%%%%%%%%%%%%#(/(#%%%%%%%%%%%%((####(%%%%%%%%%%%%%%%%%%
##############%#####(###(((((((((#%%%%%%%%%%%%%%%%/((((/(########(#(/((#%%%%%%%%%%%%%%%(((((((((((/(#%%%%%%%%%%%%%%%%%%%
%%%#%##%#########%####((#((((((##%%%%%%%%%%%%%%%%(////((//(((((//(///((((((*/((//(/((((/(/(/(((((/#%%%%%&%%&&%%%%%%%%%%%";
        string _74 = @"
*******************************,,,,,,,,,,//*,,*,***,,,,,,,,,,,,,********************************************************
*************************,,,***********,,,,,,,.,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
*******************,,*******,**,,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
*,************,*,,,,,,,.,,,,,,,,,*********,,.,,,,,,,,,,,,,,,,,........,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
#####*,,,,,,,,,,,,,...,,.,,,.....,,*,.,,,,,,,,,,,,.......,,,,,........................................,,,,,,,,,,,,,,,,,,
##########%%%%*...............................................................................................,,,,,,,,,,
#########%%%%%%%%%%%....................................................................................................
#########%%%%%%%%%%%%%%%(.........................................................,,,...................................
####%%%%%%%%%%%%%%%%%%%%%%%%%%%%*...........................................,%%%%%%####((,..............................
%%###%%%%%%%%%%%%%%%%%%&&&&%%%%%%%%%%%#.................      ..       ...,#%%%%%####((/***,............................
%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%%%%%%%%%%%%%##%#%#/*//////.             ...,%%%%%####((//*,,.............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%%%%%%&&&&&&&&&%%*/((((((((/*.      ..#%%####((((//*,,.............................
%%%%%%%%%%%%%%%%%%%%%%%%%#%#%%%%%%%%%%%#%&&&&&&&&&&&&&%#*############(((//%%%#####(((///****,,.......,,,................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&%#*/################(/########((((//**********/**//,,,,.,,,..,*///
%%%%%%%%%%%%%%%%########%#%%%%&%%%%%%##&&&&&&&&&&&&%%%%/((##%##%%#######(((((########((((((/////*//////////(/*////////((
############%%#%%#%%%##%%%%%%%%%%%%%%(%&&&&&&&&&&&%%%%#%%%%%#%%%%%######%#####(#(/######((((((((((((((((((((###((*((((((
%%##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#&&&&&&&&&&&%%%%*,.(##%%%%%%%%#%%%%%%%%%##(,###########(((((((((((#############(((#
####%%%%##%%%########%%%%%%%%%%%%%%%%%&&&&&&&&%%&%#/*(*,//%%%%%%%%%%%%%%%%%%%%%################################%##%%###(
###########%%##%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%###((#(%%#*(%%%%%%%%%%%%%%%%%%%%%%%/###%%######################%%%%%%%%%%%
####%##%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%&%%%%%%%%%%####*(/##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%###############%%%%%%%%%%%%%%%%%
%%%%%%%%%%%#%%%%#%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%###*##(#%%%%%%%%%%%%%%%%%%%%#%%%%%%%###%%%%%#%%%%%%%%%%%%%%%%%%%%%%%
%%%%#%####%##(%###%#%###(####(#######%%#(((#######%%%%%%%#/(##########(###%%%%((%%%%%%(%%#(%%%%%%%#%(%%%%%%%%%%%%%%%%%%%
####%#####(#(#(#((((((##((((((((#(/(##%%((((#####%%%/##%%%%%%%%%##((###%##/#%%%%%%%%%(%%#/#%%%%%%%#(#%%%%%%%%%%%%%%%%%%%
((((((((((((((((///(/(((((/(((/(/((#%%%%#(((((##%%%(((((/((%%%%%%%%%%##%%%%%%%%%%%%%((/%%%%%%%%%%##(%(%%%%%%%%%%%%%%%%%%
(##(####(##(###((((#(##(#######(((##%%%%%#####%%%%%/(((((#(######%%%%%%%%%%%%%#(/(#%%%%%%%%%%%%((####(%%%%%%%%%%%%%%%%%%
##############%#########(((((((((#%%%%%%%%%%%%%%%%*((((((########(#(/((#%%%%%%%%%%%%%%%(((((((((((/(#%%%%%%%%%%%%%%%%%%%
%%%#%##%#########%####((#((((((##%%%%%%%%%%%%%%%%(////((//(((((//(///((/(((*/((//(/((((/(/(/(((((/#%%%%%&%%&&%%%%%%%%%%%";
        string _75 = @"
*******************************,,,,,,,,,*//*,,*,***,,,,,,,,,,,,,********************************************************
*************************,,,***********,,,,,,,.,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
*******************,,**********,,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
,********,****,*,,,,,,,.,,,,,,,,,*********,,.,,,,,,,,,,,,,,,.,........,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
#####/,,,,,,,,,,,,,...,..,,,.....,,*,.,,,,,,,,,,,,.......,,,,,........................................,,,,,,,,,,,,,,,,,,
##########%%%#,...............................................................................................,,,,,,,,,,
#########%%%%%%%%%%#....................................................................................................
#########%%%%%%%%%%%%%%%/...............................................................................................
####%%%%%%%%%%%%%%%%%%%%%%%%%%%%,............................................#%%%%%###((*...............................
%%###%%%%%%%%%%%%%%%%%%&&&&%%%%%%%%%%%( ................      ....     ...*%%%%%%####((/***.............................
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%%%%%%%%(((/((////////.             ...*%%%%####(((/**,,.............................
%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%%(*/(((((((//*.      .,#%%####((((/**,,.............................
%%%%%%%%%%%%%%%%%%%%%%%%%#%#%%%%%%%%%%%##%&&&&&&&&&&&&&#*############(((//%%#####(((////****,...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%&&&&&&&&&&&&&%%,*################(#####((#((/(///***,**,******/*,,.,.,,,..,*///
%%%%%%%%%%%%%%%%########%%%%%%&%%%%%%##%&&&&&&&&&&&&%%%#/(##%##%%#######((((########(((((///////*//////////(**////////((
############%%%%%#%%%#%%%%%%%%%%%%%%%##&&&&&&&&&&&%%%%%%/%%#%%%%%#(#########(((##(######((((((////(((((((((((##((*((((((
%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(%&&&&&&&&&&&%%%(*,(##%%%%%%%#(%%%%%%%%###*(########((((((((((((((#############/((#
####%%%%#%%%%########%%%%%%%%%%%%%%%%%%&&&&&&&&&&%%##(,,,*%%%%%%%%%%%%%%%%%%%%%##(#############################%#######/
#################%%%%%%%%%%%%%%%%%%%%%&&&%%%%%%%####%%(/,*/%%%%%%%%%%%%%%%%%%%%%%/##%%%######################%%%%%%%%%%%
####%##%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%&%%%%%%%%####((###%#(%%%%%%%%%%%%%%%%%%%%%(%##%%%%#################%%%%%%%%%%%%%%%
%%###%%%%%#%%%%#%%%%%%%%%%#%%%%%%%(%%%%%##%%%%%%%%%######(,%%%%%%%%%%%%%%%%%%%%(%%%%%%%####%%%%%####%%%%%%%%%%%%%%%%%%%%
%%##%###(%####%##%%#%##(############%%%%#(%%%%%%%%%%%%%#(*###((#(//##%%########%%%%%%%/%%##%%%%%%%%%*%%%%%%%%%%%%%%%%%%%
##%#%%####(##((#(((((((#(((((((((((((#%%((((######%%#%%%%%%%#((((/########%%%%%%%%%%%%%%%#(%%%%%%%((/%%%%%%%%%%%%%%%%%%%
((((((((((((((((/(((((/(((((((///(((#%%%#(((((###%%%(/(###%%%%%%%%%%###%%%%#%%%%%%%/(((##%%%%%%%%%((##%%%%%%%%%%%%%%%%%%
#######((#((###((#((#######%##(((((##%%%%##(####%%%%/(##########%%%%%%%%%%%%%%%#//((((%%%%%%%%%%###((#%%%%%%%%%%%%%%%%%%
############(%#########(((((((((((#%%%%%%%%%#%%%%%%#((###########/((/((%%%%%%%%##%%%%%%%%%%%((((((/(%#%%%%%%%%%%%%%%%%%%
%%#%#%%#########%%###((((((((((###%%%%%%%%%%%%%%%%///((//(//(//(/((///(/((((#%%##((((((/((((((/((/#%%%%%%%%&&%%%%%%%%%%%";
        string _76 = @"
*******************************,,,,,,,,,*//*,,,***,,,,,,,,,,,,,,********************************************************
*************************,,,***********,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
*************,****,,,******,****,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
,********,,,,,,,,,,,,,..,,,.,,,,,*********,,,,,,,,,,,,,,,,,,.............,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
####(,,,,,,,,,,,,,........,,.....,,,,.,,.,,,,,,,,........,,,,,........................................,,,,,,,,,,,,,,,,,,
##########%%%#,...............................................................................................,,,,,,,,,,
#########%%%%%%%%%%/....................................................................................................
#########%%%%%%%%%%%%%%%/...............................................................................................
####%%%%%%%%%%%%%%%%%%%%%%%%%%%#/............................................/%%%%####(/................................
%%##%%%%%%%%%%%%%%%%%%&%&&%%%%%%%%%%%%/.................      ....     ...#%%%%%####((//**..............................
%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%%%%%%%%%%((((((((/(///*               .,#%%%#####((//**,,.............................
%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%&&&&&&%/*//(((((((//,       .#%%####((((//**,..............................
%%%%%%%%%%%%%%%%%%%%%%%%#%%#%%%%%%%%%%%%%#&&&&&&&&&&&&%%*(##########((((//#######(((////***,............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%%#(&&&&&&&&&&&&&&%#,/###############/####((((((/(///***,*,********,,....,,...,*///
%%%%%##%%%%#%%%%#####%####%%%&%%%%%%%%#(%&&&&&&&&&&&&&%%(*(####%%######(((((#######(((((((//////*///////////*/////////((
%#########%#%#%%#%%%%#%%%%%%%%%%%%%#%#/%%&&&&&&&&&&&%%%%/#%#%%%%%##########(###########((((((////(((((((((((((((*(((((((
%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##%&&&&&&&&&&&%%%#(((%%%%%%%%#(%%%%%#%%##//#/######(#(((((((((((((#(##########((((#
##%%%%%##%%%%#######%%%%%%%%%%%%%%%%%#%%&&&&&&&&&%%%##*,,/%%%%%%%%%%%%%%%%%%%%%#########################################
#################%%%%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%%(///,,,.%%%%%%%%%%%%%%%%%%%%%####%%#######################%%%%%%%%%%%
#######%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%#%((#((%#/,*%%%%%%%%%%%%%%%%%%%%%(%#%%%%%#################%%%%%%%%%%%%%%%
%%##%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%####(*///#(%%%%%%%%%%%%%%%%%%%#%%%%%%%/###########%%%%%%%%%%%%%%%%%%%%%
%##%#%##%####%##%%#%###############%%%&%%#%%%%%%%%%%####/###*#%%%(/%%%#%%%%%%%#%%%%%%%#####%%%%%%%%#(%%%%%%%%%%%%%%%%%%%
###%#####((#((#(((((((#((((((((#(/(((#%%#((#%%%%%#%%%%%####*######/*/#####(/#%%%%%%%(%%%#%(%%%%%%%#((%%%%%%%%%%%%%%%%%%%
(((((((((((((((/(((/(/(((((((///(((((#%%%((((#####%%%##%%%%%%###%#####((##%#%%%%%%%(((#((#%%%%%%%%((#%%%%%%%%%%%%%%%%%%%
#(####((#(#(##((#((#######%##(((((((#%%%%#((((((##%%%(######%%%%%%%%%%%%%%%%%%%%(/((/(/%%%%%%%%%%%(/(%%%%%%%%%%%%%%%%%%%
############%####(##(#(/(((((((((((##%%%%%##(((##%%%##((((######(((//%#(#%%%%%(///(%%%%%%%%%%%((((/##%%%%%%%%%%%%%%%%%%%
%%%%%%#########%%###(((((((####((((%%%%%%%%%%%%%%%%#/((////((////////(/#%%%%%%%%%%%%%%((((/((/(((/%%%%%%%%%%%%%%%%%%%%%%";
        string _77 = @"
*******************************,,,,,,,,,*//*,,,***,,,,,,,,,,,,,,********************************************************
*************************,,************,,,,,,.,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
*************,****,,,******,***,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
,********,,,,,,,,,,,,,..,,,.,,,,,*********,,,.,,,,,,,,,,,,,,............,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
#####,,,,,,,,,,,,,........,,....,,,,,,,,..,,,,,,,........,,,,,........................................,,,,,,,,,,,,,,,,,,
##########%%%#,...............................................................................................,,,,,,,,,,
#########%%%%%%%%%%*....................................................................................................
#########%%%%%%%%%%%%%%%/...............................................................................................
####%%%%%%%%%%%%%%%%%%%%%%%%%%%#/............................................*%%%####((,................................
%%##%%%%%%%%%%%%%%%%%%&%&&%%%%%%%%%%%%*.. ..............      ....  ......#%%%%%####((/***..............................
%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%&%%%%%%%%%%%%(((((((((////*               ./%%%%#####((//**,..............................
%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%#%%%&&%%*/(((((((((//,      .,#%%%###((((//**,..............................
%%%%%%%%%%%%%%%%%%%%%%%%#%#%%%%%%%%%%%%%%%%&&&&&&&&&&&%#*(##########((((//#######(((///****,............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%#%&&&&&&&&&&&&&&%**####################((((((////****,*,**,*****,,....,,...,*///
%%%%%##%%%##%%%%#####%####%%%&%%%%%%%%###&&&&&&&&&&&&&&%%/*####%%######(((/(#######(((((((/////////////////**/////////((
%##########%%#%%#%%%%#%%%%%%%%%%%%%%%#/#%&&&&&&&&&&&&%%%#(%#%%%%%##########(###########((((((////((((((((((((((//(((((((
%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/%&&&&&&&&&&&%%%%##(#%%%%%%%##%%%%%#%%##*(((######(#(((((((((((((#(##########/(((#
##%%%%%#%%%%########%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%%##(,,(%%%%%%%%%%%%%%%%%%%%##(#####################################(#
#################%%%%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%%#(/*,,,,%%%%%%%%%%%%%%%%%%%%%(####%#######################%%%%%%%%%%%
#######%%%%%%%%%%%%%%%%%%%%%%%%%%%%##%%%%%%%%%%%%###/(%(,,*#%%%%%%%%%%%%%%%%%%%#%%#%%%%##################%%%%%%%%%%%%%%%
%%##%%%%%#%%%%#%%%%%%%%%%#%%%%%%%%##%%%%%%%%%%%%####(/((#%(/%%%%%%%%%%%%%%%%%%#%%%%%%%%(###########%%%%%%%%%%%%%%%%%%%%%
###%#%##%#%#%%#%%%#%##(#############%%%%%#%%%%%%%%%%#######,##%%%((%%%%%%%%%%#%%%%%%%######%%%%%%%%##%%%%%%%%%%%%%%%%%%%
####%####(##((#(((((((#(/((((((((((((%%%%##%%%%%%%%%%%%###.#####*/((#######(%%%%%%%%(%###%%%%%%%%%%##%%%%%%%%%%%%%%%%%%%
((((((((((((#(///((((((((((((///(/((((%%%((((#####%%%%%%%%%%######(*,***(####%%%%%#(((#(#/*%%%%%%%#(#%%%%%%%%%%%%%%%%%%%
#######((((##(#(((############((((((/#%%%#(((((((#%%%######%%%%%%%%%%%%%%%%%%%%%%/((/((*%%%%%%%%%%(#(%%%%%%%%%%%%%%%%%%%
###################(#(/(((((((#(((#(#%%%%%##((((##%%%#(/#(######%##(##((#%%%%%//////(%%%%%%%%%%(((((#%%%%%%%%%%%%%%%%%%%
#%#%%##########%####(((((((##((((((#%%%%%%%%###%%%%%#/////((///////(/(%%%%%%%%%%%%%%%%%%##((///((/%%%%%%%%%%%%%%%%%%%%%%";
        string _78 = @"
*******************************,,,,,,,,,*///,,***,,,,,,,,,,,,,,,*,******************************************************
*************************,,**********,,,,,,,,.,,,,.,.,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
*************,,**,,,,,*****,***,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
,******,,,,,,,,,,,,,,,.,,,,..,,,,*********,,,,,,,,,,,,,,,,,,......................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
#####**,,,,,,,,,,,........,,.....,,,,,,,..,,,,,,,........,,,,.........................................,,,,,,,,,,,,,,,,,,
#########%%%%%*...............................................................................................,,,,,,,,,,
#########%%%%%%%%%%(....................................................................................................
#########%%%%%%%%%%%%%%%(...............................................................................................
###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(............................... ............/%%%####((.................................
%%##%%%%%%%%%%%%%%%%%%&%&&%%%%%%%%%%%%/,................      ..    ......%%%%%%####((/**,..............................
%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%&%%%%%%%%%%%%#(((((((((///*.              ./%%%%#####((//**,..............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%&&%%//(((((((((//,       /#%%####((((/**,,..............................
%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%#*(##########(((((/#######(((///****,,...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%#%#%&&&&&&&&&&&&&&%(*(##################((((#(//(//******,********,,....,,,,,*////
#%#%########%%%%#####%####%%%%%%%%%%%%###&&&&&&&&&&&&&&&%(,####%%#####((((*########(((((((/////*///////////**/////////((
%#######%##%%%%%%%%%%#%%%%%%%%%%%%%%##/(%&&&&&&&&&&&&%%%%/##%%%%###########(###########((((((//(/((((((((((((((//(((((((
##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#*%&&&&&&&&&&&%%%%##(#%%%%%%%#%%%%%%%%###*(#(######(#(((((((((((((############/(((#
###%%%%##%%%########%%%%%%%%%%%%%%%%%%#%&&&&&&&&&%%%###,,(%%%%%%%%%%%%%%%%%%%%##(#####################################(#
##################%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%%#/*,.*,%%%%%%%%%%%%%%%%%%%%%(###%%#######################%%%%%%%%%%%
#######%%%%%%%%%%%%%%%%%%%%%%%%%%%%##%%%%%%%%%&%%###*(%(,,*#%%%%%%%%%%%%%%%%%%%(%%#%%%%##################%%%%%%%%%%%%%%%
%%##%%%%%#%%%%%%%%%%%%%%%#%%%%%%%%##%%%%%%%%%%%%####(/((##(/%%%%%%%%%%%%%%%%%%#%%%%%%%%##########%#%%%%%%%%%%%%%%%%%%%%%
###%#%######%##%%%#%##(#(##########(%%%%%#%%%%%%%%%%###(##(,##%%%(#%%##%%%%%%(%%%%%%%(%####%%%%%%%%#%%%%%%%%%%%%%%%%%%%%
####%####(##((#(((((((((/(((((((((((/%%%%##%%%%%%%%%%#####.#####*/#(########%%%%%%%%#%###%##%%%%%%%##%%%%%%%%%%%%%%%%%%%
((((((((((((((/(/((((((((((((///(/((((#%%#((#######%%%%%%%%%#####(***,*/((##%%%%%%((((#((/*%%%%%%%#((%%%%%%%%%%%%%%%%%%%
######(##(###((#((############((((((/#%%%#(((((((##%%%####%%%%%%%%%###%%%%%%#%%%#(((/((/%%%%%%%%%%(#/%%%%%%%%%%%%%%%%%%%
###################(#(/(((((((#(((((##%%%%##(((((#%%%##(#(############((#%%%%%((/////#%%%%%%%%%#((/(#%%%%%%%%%%%%%%%%%%%
#%%%%##########%###((((((((##(#(((((%%%%%%%%####%%%%#(////((///////((###%%%%%%%%%%%%%%%%%##(//(((*%%%%%%%%%%%%%%%%%%%%%%";
        string _79 = @"
*******************************,,,,,,,,,*///,,***,,,,,,,,,,,,,,,*,******************************************************
*************************,,**********,,,,,,,,.,,,,.,.,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
*************,,**,,,,,*****,***,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
,******,,,,,,,,,,,,,,,.,,,,..,,,,*********,,,,,,,,,,,,,,,,,,......................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
#####**,,,,,,,,,,,........,,.....,,,,,,,..,,,,,,,........,,,,.........................................,,,,,,,,,,,,,,,,,,
#########%%%%%*...............................................................................................,,,,,,,,,,
#########%%%%%%%%%%(....................................................................................................
#########%%%%%%%%%%%%%%%(...............................................................................................
###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(............................... ............/%%%####((.................................
%%##%%%%%%%%%%%%%%%%%%&%&&%%%%%%%%%%%%/,................      ..    ......%%%%%%####((/**,..............................
%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%&%%%%%%%%%%%%#(((((((((///*.              ./%%%%#####((//**,..............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%&&%%//(((((((((//,       /#%%####((((/**,,..............................
%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%#*(##########(((((/#######(((///****,,...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%#%#%&&&&&&&&&&&&&&%(*(##################((((#(//(//******,********,,....,*,,,*////
#%#%########%%%%#####%####%%%%%%%%%%%%###&&&&&&&&&&&&&&&%(,####%%#####((((*########(((((((/////*///////////**/////////((
%#######%##%%%%%%%%%%#%%%%%%%%%%%%%%##/(%&&&&&&&&&&&&%%%%/##%%%%###########(###########((((((//(/((((((((((((((//(((((((
##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#*%&&&&&&&&&&&%%%%##(#%%%%%%%#%%%%%%%%###*(#(######(#(((((((((((((############/(((#
###%%%%##%%%########%%%%%%%%%%%%%%%%%%#%&&&&&&&&&%%%###,,(%%%%%%%%%%%%%%%%%%%%##(#####################################(#
##################%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%%#/*,.*,%%%%%%%%%%%%%%%%%%%%%(###%%#######################%%%%%%%%%%%
#######%%%%%%%%%%%%%%%%%%%%%%%%%%%%##%%%%%%%%%&%%###*(%(,,*#%%%%%%%%%%%%%%%%%%%(%%#%%%%##################%%%%%%%%%%%%%%%
%%##%%%%%#%%%%%%%%%%%%%%%#%%%%%%%%##%%%%%%%%%%%%####(/((##(/%%%%%%%%%%%%%%%%%%#%%%%%%%%##########%#%%%%%%%%%%%%%%%%%%%%%
###%#%######%##%%%#%##(#(##########(%%%%%#%%%%%%%%%%###(##(,##%%%(#%%##%%%%%%(%%%%%%%(%####%%%%%%%%#%%%%%%%%%%%%%%%%%%%%
####%####(##((#(((((((((/(((((((((((/%%%%##%%%%%%%%%%#####.#####*/#(########%%%%%%%%#%###%##%%%%%%%##%%%%%%%%%%%%%%%%%%%
((((((((((((((/(/(((((((((((((//(/((((#%%#((#######%%%%%%%%%#####(***,*/((##%%%%%%((((#((/*%%%%%%%#((%%%%%%%%%%%%%%%%%%%
######(##(###((#((############((((((/#%%%#(((((((##%%%####%%%%%%%%%###%%%%%%#%%%#(((/((/%%%%%%%%%%(#/%%%%%%%%%%%%%%%%%%%
###################(#(/(((((((((((((##%%%%##(((((#%%%##(#(############((#%%%%%((/////#%%%%%%%%%#((/(#%%%%%%%%%%%%%%%%%%%
#%%%%##########%###((((((((##(((((((%%%%%%%%####%%%%#(////((///////((###%%%%%%%%%%%%%%%%%##(//(((*%%%%%%%%%%%%%%%%%%%%%%";
        string _8 = @"
***************************//////////////////////////((((((((((((((((((######################################%%#%%%%%%%%
,,,*******************************////////////////////////////(((((((((((((((((((((((((#################################
,,,,,,,,,,,,,,,,,,,****************************************////////////////(((((((((((((((((((((((((((((################
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**********************************///////////////////////(((((((((((((((((((((((((((((((((
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************///////////////////////////////((((((((((((((((((((
.........,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************************//////////////////////////////(((((((((
...........................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****************************///////////////////////////////
.....................................,,,,,,,,,,,,*%&%*,,,,,,,,,,,,,*******************************//////////////////////
######,.....................................,,,#&&&&&&&%,,,,,,,,,,,,,,,,,,,,*********************************///////////
############%%(..............................,#&&&&&&&&&&,,,,,,,,,,,,,,,,,,,,,,,**********************************//////
#######%%%%%%%%%%%%%%%%%%%%................./#%%&&&&&&&#,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/,.......(/#&&&&&&&&*....,,,,,,,,,,,,,,,,,,,,,,,,,,,**********************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(/*/%&&&&&&&&&,.....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************
#%%%%%%%%%#######%%%%%%%%%%&&&%&%%%%%%%/(*#&&&&&&&&&&&%%%%%%%%&%#,,,,,,,,,,,,,,,****************************************
#############%%%#%%%%#########%%%&&%%##/*(%&&&&&&&&&&&%###%%%%&&&&&&&&&&&&&&%%%%%%##((/*********************************
###############################%%%%%%%%/*(&&&&&&&&&&&&######%%%%%%&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%&%%%%%%%(//*//**////
####%%%%%%%#%##########################**%&&&&&&&&&&&&%%%%%%%&&&&&%%##%%%%%&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%
%%%%%%%%#####%%##########%%%##########,,(%&&&&&&&&&&&&###/#&@@@&####%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%#####%%%%#%#########%%###%%%%%%%,*/%&&&&&&&&&&&&&&&/(&&&@@@%%%##%#############%####%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&
%%%%%%%%%%%%%&%%%%%%%%%%%%%#%#%%%#%**/#%&&&&&&&&&&&&&&&/#(%&&&&&&&&&%%%%%%#%%%%#######%#####%#######%%%%%%%%%%%%%%%%%%%%
###%###%%#####%#%########%%###%%%%/(*%&&&&&&&&&&&&&&&&&#//*%&&&&&&%&&&&&&%&&%%%%&#%%%#%%%&&&&&&&%##%%########%%%%%%%%%%%
((((#(((((((((((((((((((((((((((((*%/&&&&&&&&&&&&&&%#&&&&%%%#&&&&&%%###&&%%&%%&&&%%&%%%%%#%&&%#%%%%#%%%%%(##%%#%%#%%%%#%
###########%####(#(#####%%###((((((%*&&&&&&&&&&&&&&&%%#(((#%&%&&&&%%#(((#(#####((#(###(##(((((####(######%###(#########%
#####################%#######((####%(&&&&&&&&&&&&&&&%%#%%%&%%%%%%%%%###(####################%%#########(##%##%#%%%#%#%%%
#%%%%%%%%######%####((#####(######&#(&&&&&&&&&&&&&&&%######%&%%%%%%%%##(((####(#%%%%%%%#####%%#########################%
&%%%%&&%&%%%%%%####(##%#(###((###%&##%&&&&&&&&&&&&&&%#####%%%%%%%%%%%##%%%%&%%%&&%%%%%%%%%%#%###%%###%%##%#%####%#%#%%%%
&&&&&&&&&&&&&&&&%%%##%%%%%%%%%##/&&%(&&&&&&&&&&&&&&&&%(###(/%%%%%%%%%#%&%%#%#%%%%%#%%%#%%%#%%%%#%%%##%%%#%%%%%%%%%%%%%%#";
        string _80 = @"
********************,**********,,,,,,,,,*///*,,**,,,,,,,,,,,,,,,,,******************************************************
*******************,,****,,**********,,,,,,,,.,,,,....,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
*************,,**,,,,,*****,***,,,,,,,,,,,,,,,,,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******
,,****,,,,,,,,,,,,,,,,.,,,,,..,,,*********,,,,,,,,,,,,,,,,,,......................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**
#####/*,,,,,,,,,,......,..,,.....,,,,,,,..,,,,,,,........,,,,.........................................,,,,,,,,,,,,,,,,,,
#########%%%%#*...............................................................................................,,,,,,,,,,
#########%%%%%%%%%%(....................................................................................................
#########%%%%%%%%%%%%%%%#,.,............................................................................................
###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#............................... ............(%%%####((.................................
%%##%%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%%%%(**...............      ..    ......%%%%%%####((/**,..............................
%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%%%%%%%%%%#(((((((((////.              .#%%%%#####((//*,,..............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%&&%(/(((#(((((//*      .(%%%####((((/**,,..............................
%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%#&&&&&&&&&&&&%(*(#########((((//#######((////****,,...........................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%#&&&&&&&&&&&&&&%%,/##############%###((((((/((//******,*********,....*****/////
#%#%#########%%%#####%###%%%%%%%%%%%%%%%(&&&&&&&&&&&&&&&%%,/##########((((,#########((((((/////*///////////***////////((
%######%%%%%%%%%%%%%#%%%%%%%%%%%%%%%##(/%&&&&&&&&&&&&&%%%(/#%%%%#######################((((((//((((((((((((((((//(((((((
##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/#%&&&&&&&&&&&%%%###(%%%%%%%#%%%%%%%%###*###########(((((((((((((############/(((#
##%%%%%##%%########%%%%%%%%%%%%%%%%%%%(%%&&&&&&&&%%%%##*,/%%%%%%%%%%%%%%%%%%%%##(#####################################/#
###############%##%%%%%%%%%%%%%%%%%%%##%&&%%%%%%%%%%%#(,,*/%%%%%%%%%%%%%%%%%%%%######%#######################%%%%%%%%%%%
#######%%%%%%%%%%%%%%%%%%%%%%%%%%%%###%%%%%%%&&%%%%%*(%/../#%%%%%%%%%%%%%%%%%%%(###%%%%##################%%%%%%%%%%%%%%%
%%##%%%%#%%%%#%%%%%%%%%%%%%%%%%%%%%(#%%%%%%%%%%%####(*(#%/*/%%%%%%%%%%%%%%%%%%(%%%%%%%###########%#%%%%%%%%%%%%%%%%%%%%%
####%#(%####%##%%#%%###############*%%%%%#%%%%%%%%%%###/##/.#%%%%#%%%##%%%%%%(%%%%%%%/%%###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
##%###(#((#((#((((((((((((((((((((((/%%%%%#%%%%%%%%%%####/*####(,#(/########%%%%%%%%%%##%###%%%%%%%(%%%%%%%%%%%%%%%%%%%%
((((((((((((((((/(/(((((((((///((((((/(#%#((#######%%%%%%####((//**/*,/%(/#%%%%%%%/#((#((((%%%%%%%%((%%%%%%%%%%%%%%%%%%%
#####((#(####((#((#(########((((((/(((#%%%((((##(##%%%%###%%%%%%#%#######%%#%%%%%((((((/#%%%%%%%%%(#/%%%%%%%%%%%%%%%%%%%
###########%####(####//((((((#(((#(((#%%%%##((((((#%%%#((######%%%%%%%##%%%%%%%#/////(%%%%%%%%%%#(/(%%%%%%%%%%%%%%%%%%%%
%%%%##########%%###((((((((###(((/((#%%%%%%#######%%%#(((/((///////(((((%#%%%%%%%%%%%%%%%%%%(/((/*%%%%%%%%%&%%%%%%%%%%%%";
        string _81 = @"
*********/***********************,,,,,,,*///*,****,,,,,,*,,,,,,,**********************************************//////////
****************************************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**********************************
******************,,,*********/*,,,,,,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
*******,*************,,,,,,,,,,,,**********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,********
#####/*,,,,,,,,,,,,,.,,,..,,,..,.,,****,..,,,,,,,........,,,,...,,,,,,................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
###%%%%%%%%%%%,......,..,,,,,,,,.....,,,,,,.........................................................,,.,,,,,,,,,,,,,,,,,
##%%%%%%%%%%%%%%%%%(............................................................................................,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%%%#,.*............................................................................................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#............................................#%%%%###((.................................
%%%%%%%%%%%%%%%%%%%%&&&&&&&&%%%%%%%%%%(/*,...............................,%%%%%%%###((/**,..............................
%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%%%%%%%%%%#((((((((((((/.   ..  .......,#%%%%%%###((//**,..............................
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&%%%%%%%%%%%%%%&&&&&#/(####(((((/*  .....#%%%%%###(((/***,..............................
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%%%%%%&&&&&&&&&&&&&(*(############(/(%%%%###(((///****,,...........................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%%%%%%%%%%%%#&&&&&&&&&&&&&&&&(*###%#########%%########((((//***********///***.,..****//////
%%%%%%%%%%##%%%%%%%%%%%##%%%&&&&&%%%%%%%(%&&&&&&&&&&&&&&&%(*##%%%%######((*#%%########(((((////////////((((*/////(((((((
%###%%%%%%%%%%%%%%%%%%%%&&&%%&%%%%%%%##/%&&&&&&&&&&&&&&%%%/(%%%%##%%%%#%##(####%########(((((((((((((((((#####(*(((((((#
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%%%%((&&&&&&&&&&&&&%%%##*%%%%%%%#%%%%%%%%%%#/#############((((((((###############/####
%%%%%%%%%%%%%#####%%%%%%%%%%%%&%%%%%%%(%&&&&&&&&&%%%%%##**#%%%%%%%%%%%%%%%%%%%%###%%########################%%%%%%%%%#/#
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&%%%,*/(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##########%%##%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%&&&&&&&&%%%#/%/,,*(%%%%&%&&&&&%%%%%%%%#%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%#%%%%%%%%%%%%%%%#%%%%%%%%%%%#%&&&&&&&&&%%%%((((#%*.#%%%%%%%%%%%%%%%%%%#%%%%%%%#%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%#%#%##%%%#%%%%%%%%###%##%#####%%%%/#&&&&#%%%%%%%%%%%##/##*,#%%%%#%%%%%%%%%%%#%%%%%%%(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
###%####(#####(#((((##((((((((#(((#((#&&&%#%%%%%%%%%%%%%%/*###%//##/##%%####%%%%%%%#%%%%%%%%%%%%%%%(%%%%%%%%%%&%%%%%%%%%
#####(####((((((((((((((((((/(/((((((((#%%###%%%%##%%%%%%%%##****(##,/#%#%%%%%%%%%(#((#((##%%%%%%%%(#%%%%%%&&&%%%%%%%%%%
################(###%%#%#%#####((((/((%%%%#((######%%%%##%%%%%%%%%%%%%%%%%%%%%%%#(((((((#%%%&&&&&&##/%%%%&&&&&&%%%%%%%%%
%%%###%###%#######(##((#(#(((#(((#((##%%%%%########%%%%#######%%%%%%%%%%%%%%%%%#(/((//%%%&&&&&&&%(*(%&%%&&&&&%%%%%&&&&&&
%%%%%%%%##%##%%#######(#######(#(((((%%%%%%%######%%%%#(((((((((///(((((%#%%%%%%%%%%%%&&&&&&#(((((%%&%%&&&&&&&&&&&&&&&&&";
        string _82 = @"
*/*///////////*/********************,*,*,////*,,****,,,,,,,**,,,,******************************************/////////////
***********//****///*,*******************,*,*,,,**,,,,,,,,,,,,,,,,,,*************************************************///
*******************,,********///**,**,,,,*****,,,,,,,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
/*******,*************,,,,*,,,,,,,**************,,,,,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
%%%%%%#/***,,,,,,,,,,,,,,.,,,,..,,,****,..,,,,,*,,.,,,,...,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**
%%%%%%%%%%%%%%%.,,,,,,,,,,,..,,,,,,,,,,,,,,,.......,,,,,,,,,.....,,,,,...............,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%#..........,......................................................................,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%&%%%%%%......................................................................................,,,,,,
%%%%%%%%%%%%%%%%%%%%&&&&%%%%&&&%%*..........................................(%%%%%####(.................................
%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%%%%%%%%((#(###(,.........................#%%%%%%%%###((/*,..............................
%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%%%%%%%%%%%(#((((((((((((............../%%%%%%%####((/**,..............................
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%%%%%%%%%%%&&&&&&&&%/(######((/.......%%%%%%###(((//***,.............................
%%%%%%%%&%%%%%&&&&&&&&&%%%%%%%%%&&&&&%%%%%%%&&&&&&&&&&&&&%(/####%%######/%%%%%%##(((((//***,,.,.........................
%%%%%%%%%%%%&%%%%%%&%&&&&&&&&%%%%%&%%%%%%%%&&&&&&&&&&&&&&&&#,#%%%%#######%%########(((((////****//*////***,,..//////((((
%%%%%%%%%%##%%%%%%###%##%%&&&&&&&&%%%%%%%(&&&&&&&&&&&&&&&&&(,#%%%%#######,,%%%%%#######((((((////(//(((((((*//((((((((((
%#%%%%%%%%%%%%%%%%%%%%%%&&&%&&%&&%%%%##((&&&&&&&&&&&&&&&%%%((%%%##%%%%%%####%%%%%%########((((((((((((#########*(((#####
%%%%%%%%%%%%%%%%%%%%%%%%%%%&%&&&&&%&%##/%&&&&&&&&&&&&&&%%#%*%%%&%%#%%%%%%%#%%#*%%%#%%#######################%######/####
%%%%%%%%%%%%%#%%%%%%%%%%%%&&%%%%%%%%%%%/%&&&&&&&&&&&&&%%/*(#&&&%%%%%%%%%%%%%%%%#%%%%%%%%%##############%%%%%%%%%%%%%%#(%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&%##(/*%&&%&%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%##%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%%#%%&&&&&&&&&&%%###/,/%%%%%&&&&&&&%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%&&&&&&&&&&%%##(//%**#%&&%%&%%%%%%%%%%%%%%%%%%%%(%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%#%##%%%#%#%%%%#%%%%##%##%%%%%%%%%%/(&&&&(&%%%&%%%%%%#((//.%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
###%##############(##(((((((((((((#((((&&&&%&%%%%%%%%%%%%#*(##(*(#####%%##%%%%%%%%%#%%%%%%%(%%%%%%%#%%%%%%%%%&&&&&&&%%%%
####(#####(#(((((#(((#((((((((((((((((((#%%###%%%%%%%%%%%%%%#,%#%%%*/(#/%%%%&&&&&&/########%%&&&%%%(&%%%%%&&&&&&&%%%%%%%
#%#######%#########%%%%%%%#%#####(((((#%%%%#########%%%%%%%%%%%%%%%%%%#(#%%%%&&&%(#(((#((%&&&&&&&&%(#&&&&&&&&&&&&&&&&&%%
%%#%%%%%##%%##%#####(####(#(###(#((####%%%%%########%%%%###%%%%%%%%%%%%%%%%%%//(((((((/%%&&&&&&&&&(%%%&&&&&&&&&&&&%&&&&&
%%%%%%%%%%%%%%##%######(########((#((#%%%%%%%%#####%%%%%%##((((((/((((##/#%%%%%%%%%%%&&&&&&&&&#(/%%&&&&&&&&&&&&&&&&&&&&&";
        string _83 = @"
*/*///////////*/********************,*,*,////*,,****,,,,,,,**,,,,******************************************/////////////
***********//****///*,*******************,*,*,,,**,,,,,,,,,,,,,,,,,,*****,,******************************************///
*******************,,********///*****,,,,*****,,,,,,,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
/*******,*************,,,,*,,,,,,,**************,,,,,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
%%%%%##(***,,,,,,,,,,,,,,.,,,,..,,,****,..,,,,,*,,.,,,,...,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**
%%%%%%%%%%%%%%%.,,,,,,,,,,,..,,,,,,,,,,,,,,,.......,,,,,,,,,.....,,,,,...............,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%#..........,.......................................................................,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%&&%%%%%%......................................................................................,,,,,,
%%%%%%%%%%%%%%%%%%%%&&&&%%%%&&&%%*..........................................(%%%%%####(.................................
%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%%%%%%%%((#(###(,.........................#%%%%%%%%###((/*,..............................
%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%%%%%%%%%%%(#((((((((((((............../%%%%%%%####((/**,..............................
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%%%%%%%%%%%&&&&&&&&%/(######((/.......%%%%%%###(((//***,.............................
%%%%%%%%&%%%%%&&&&&&&&&%%%%%%%%%&&&&&%%%%%%%&&&&&&&&&&&&&%(/####%%######/%%%%%%###((((//*/*,,.,.........................
%%%%%%%%%%%%&%%%%%%&%&&&&&&&&%%%%%&&%%%%%%%&&&&&&&&&&&&&&&&#,#%%%%#######%%########(((((////****//*////***,,.,//////((((
%%%%%%%%%%##%%%%%%###%##%&&&&&&&&&%%%%%%%(&&&&&&&&&&&&&&&&&(,#%%%%#######,,%%%%%#######((((((////(//(((((((*//((((((((((
%#%%%%%%%%%%%%%%%%%%%%%%&&&%&&%&&%%%%##((&&&&&&&&&&&&&&&%%%((%%%##%%%%%%#%##%%%%%%########((((((((((((#########*(((#####
%%%%%%%%%%%%%%%%%%%%%%%%%%%&%&&&&&%&%##/%&&&&&&&&&&&&&&%%#%*%%%&%%#%%%%%%%#%%#*%%%#%%#######################%######/####
%%%%%%%%%%%%%#%%%%%%%%%%%%&&%%%%%%%%%%%/%&&&&&&&&&&&&&%%/*(#&&&%%%%%%%%%%%%%%%%#%%%%%%%%%##############%%%%%%%%%%%%%%#(%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&%##(/*%&&%&%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%##%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%%#%%&&&&&&&&&&%%###/,/%%%%%&&&&&&&%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%&&&&&&&&&&%%##(//%**#%&&%%&%%%%%%%%%%%%%%%%%%%%(%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%#%##%%%#%#%%%%#%%%%##%##%%%%%%%%%%/(&&&&(&%%%&%%%%%%#((//.%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
###%##############(##((((((((((((((((((&&&&%&%%%%%%%%%%%%#*(%%(*(#####%%##%%%%%%%%%#%%%%%%%(%%%%%%%#%%%%%%%%%&&&&&&&%%%%
(###(#####(#(((((#(((#(((((/((((((((((((#%%###%%%%%%%%%%%%%%#,%#%%%*/(#/%%%%&&&&&%/###(####%%&&&%%%(&%%%%%&&&&&&&%%%%%%%
#%#######%#########%%%%%%%#%#####(((((#%%%%#########%%%%%%%%%%%%%%%%%%#(#%%%%&&&%(#(((#((%&&&&&&&&%(#&&&&&&&&&&&&&&&&&%%
%%#%%%%%##%%##%#####(####(#(###(#(#####%%%%%########%%%%###%%%%%%%%%%%%%%%%%%//(((((((/%%&&&&&&&&&(%%%&&&&&&&&&&&&%&&&&&
%%%%%%%%%%%%%%##%######(#########(#((#%%%%%%%%#####%%%%%%##((((((/((((##/#%%%%%%%%%%%&&&&&&&&&#(/%%&&&&&&&&&&&&&&&&&&&&&";
        string _84 = @"
*/*///////////*/********************,*,*,////*,,*****,,,,,,**,,,,******************************************/////////////
***********//****///*,*******************,*,*,,,**,,,,,,,,,,,,,,,,,,************************************************////
*******************,,********///*****,,,,*****,,,,,,,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************
/*******,*************,,,,*,,,,,,,**************,,,,,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
%%%%%%#/***,,,,,,,,,,,,,,.,,,,..,,,****,..,,,,,*,,.,,,,...,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**
%%%%%%%%%%%%%%%.,,,,,,,,,,,..,,,,,,,,,,,,,,,.......,,,,,,,,,.....,,,,,...............,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%#..........,.......................................................................,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%&&%%&%%#......................................................................................,,,,,,
%%%%%%%%%%%%%%%%%%%&&&&&%%%%&&&%%,..........................................(%%%%%####(.................................
%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%%%%%%%%((#/###/,.........................%%%%%%%%%###((/*...............................
%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%%%%%%%%%%%(##((((((((((/..............(%%%%%%%%###((/**,..............................
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%%%%%%%%%%%&&&&&&&&&/(######((( ......%%%%%%%##(((//***,.............................
%%%%%%%%&%%%%%&&&&&&&&&%%%%%%%%%&&&&&%%%%%%%&&&&&&&&&&&&&&#/(###%######(*%%%%%%###((((//*/*,,...........................
%%%%%%%%%%%%&%%%%%%&%&&&&&&&&%%%%%&&%%%%%%%&&&&&&&&&&&&&&&&&,(#%%%######%%%########(((((////****//*////***,,.,*////(((((
%%%%%%%%%%##%%%%%%###%##%%%&&&&&&&%%%%%%%(&&&&&&&&&&&&&&&&&#*(%%%%#######,*%%%%%#######((((((///((//(((((((*//((((((((((
%#%%%%%%%%%%%%%%%%%%%%%%&&%%&&%&&%%%%##((%&&&&&&&&&&&&&&&%%((%%%##%%%%%%%#(#%%%%%%#########((((((((((#########(*((######
%%%%%%%%%%%%%%%%%%%%%%%%%%%&%&&&&&%&%%#/#&&&&&&&&&&&&&&%%#%*%%%&%%#%%%%%%%#%%#*%#%%%%#######################%%%%###(####
%%%%%%%%%%%%%%%%%%%%%%&&%%&&%%%%%%%%%%%/%&&&&&&&&&&&&&%%(*(#&&&%%%%%%%%%%%%%%%%#%%%%%%%%%#############%%%%%%%%%%%%%%%#(#
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&%##(/*%&%%&%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%%%#%%&&&&&&&&&&%%#(#(,/%%%%%&&&&&&&%%%%%%%(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%&&&&&&&&&&%%%#(/*#/*#%&&%%&%%%%%%%%%%%%%%%%%%%%(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%##%%%#%%%%%%%%%%#%#%%#%%%%%%%%%%((%&&&%%&%%&%%%%%%%#///.%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
###%##############(##((((((((#((((((#((&&&&%&%%%%%%%%%%%%#*(%%/((#%##%%%%#%(%%%%&&%%%%%%%%%/%%%%%%%#%&%%%%%%%&&&&&&&%%%%
##########(#(((((((((#(#(((/((((((((((((#%%###%%%%%%%%%%%%%%#,%%%%%,(((*#%%%&&&&&&(###(####(%&&%%%%(&%%%%%&&&&&&&%&&&&%%
#%#######%#####(###%%%%#%%#%####((((((##%%%#########%%%%%%%%%%%%%%%%(//*#%%%&&&&%(#(((##/(/&%&&&&&%(#%&&&&&&&&&&&&&&&&&&
%%%#%%%###%###%#####(####(#(###(#(#####%%%%%%#######%%%%##%%%%%%%%%%%%%%%%%%%//(((((((/%&&&&&&&&&&(%%%&&&&&&&&&&&&&&&&&&
%%%%%%%%#%%%%%##%###############((#((#%%%%%%%%%####%%%%%%#####(((/((((#((%%%%%%##%%&%&&%&&&&&&%#/%%&&&&&&&&&&&&&&&&&&&&&";
        string _85 = @"
*/*///////////**********************,*,*,////*,,*/***,,,,,,**,,,,*****************************************//////////////
***********/*****///*,*******************,*,*,,,**,,,,,,,,,,,,,,,,,,************************************************////
*******************,,*********//*****,,,,*****,,,,,,,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,,**********************
********,*************,,,**,,,,,,***************,,,,,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
%%%%%%(/***,,,,,.,,,,,,,,.,,,..,,,,****,..,,,,,*,,.,,,....,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******
%%%%%%%%%%%%%%#..,,,,,,,,,,.,,,,,,,,,,,,,,,,.......,,,,,,,,,.....,,,,,,,,...........,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%#..........,..................................................................,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%&%%%%##.....................................................................................,,,,,,,
%%%%%%%%%%%%%%%%%%%&&&&&%%%%%&&%%,..........................................(%%%%%%###(...............................,,
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&%%%%%%%%((#*(((/..........................%%%%%%%%%###((/*...............................
%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%%%%%%%%%%%###((((((((((/ .............(%%%%%%%%###((/**,..............................
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%%%%%%%%%%%&&&&&&&&&&/((####((( .....,%%%%%%%###((//***,.............................
%%%%%%%%&&%%&&&&&&&&&&&%%%%%%%%%&&&&&%%%%%%%&&&&&&&&&&&&&&&#((##%%#####(,%%%%%%###((((////*,,...........................
%%%%%%%%%%%%%%%%%%%&%&&&&&&&&%%%%%&&%%%&&%%&&&&&&&&&&&&&&&&&%*(%%%######%%%#########(((((///****//*////***,,.,*////(((((
%%%%%%%%%%##%%%%%%###%##%%%&&&&&&&%%%%%%%#%&&&&&&&&&&&&&&&&%(*#%%%#######,(%%%%%#######(((((((//(((/(((((((*//((((((((((
%#%%%%%%%%%%%%%%%%%%%%%%&&%%&&%&&%%%%###(#&&&&&&&&&&&&&&&&%((#%%##%%%%%%%#(#%%%%%%%########((((((((((#########(/((######
%%%%%%%%%%%%%%%%%%%%%%%%%%%&%&&&&&%&%%%(/%&&&&&&&&&&&&&&%%#%#%%&%%#%%%%%%%%%%#/%%%%%%#######################%%%%##(#####
%%%%%%%%%%%%%%%%%%%%%%&&&%&&%%%%%%%%%%%%(&&&&&&&&&&&&&&%#**#%%&%%%%%%%%%%%%%%%%#%%%%%%%%%%###########%%%%%%%%%%%%%%%%#%#
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%&&&&&&&&&&&&&%(/**(%%%&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%%&&&&&&&&&&&%%/(#(*#%%%%&&&&&&&%%%%%%%(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%&&&&&&&&&&&%%##,**//%&&%%&%%%%%%%%%%%%%%%%%%%%(%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
#%%%##%###%%%%%%%%%%#%#%%#%%%%%%%%%%%#(&&&&%&%%%&%%%%%%#//*.%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%
##%%##############(###((((##((((((((#((%&&&%&&%%%%%%%%%%%%#*(#/((##(#%%%%#%/#%&&&&&%%%%%%%%#%%%%%%%%%&%%%%%%%&&&&&&&%%%%
##########(#(((((((((#(#(#(/((((((((((((#%%%##%%%%%%%%%%%%%%#.%%%%%,(((*/%%%&&&&&&%########/&&&&&&&%&%%%%%&&&&&&&&&&&&%%
#%#############(#%#%%%%#%##%###(((((((#(%%%%#########%%%%%%%%%%%%%%#*,*/%%%&&&&&%/#(((###/*%%&&&&&&/%%&&&&&&&&&&&&&&&&&&
%%%#%#%#%%%#%#%####(((#####(##((#(######%%%%%########%%%%#%%%%%%%%%%%%%%%%%%%(((((((((((&&&&&&&&&&%%&&&&&&&&&&&&&&&&&&&&
%%%%%%%%%%%%%%%########(#######(((#((#%%%%%%%%%%####%%%%%%####(((/(#(((##%%%%%%(/(%&&&&&&&&&&&&&#%#&&&&&&&&&&&&&&&&&&&&&";
        string _86 = @"
*/*///////////**********************,*,*,////*,,*/***,,,,,,**,,,,*****************************************//////////////
***********/*****///*,*******************,,,*,,,**,,,,,,,,,,,,,,,,,,************************************************////
*******************,,*********//*****,,,,*****,,,,,,,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************
/*******,*************,,,,*,,,,,,,**************,,,,,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
%%%%%%#/***,,,,,.,,,,,,,,.,,,...,,,****,..,,,,,,,,.,,,,...,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******
%%%%%%%%%%%%%%%.,,,,,,,,,,,..,,,,,,,,,,,,,,,.......,,,,,,,,,.....,,,,,,,,.............,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%#..,,......,......................................................................,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%&%%%%%#...................................................................................,,,,,,,,,
%%%%%%%%%%%%%%%%%%%&&&&&%%%&&&&%%*.........................................,%%%%%%%###(...............................,,
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&%%%%%%%%((#(###(,.........................%%%%%%%%%###((/*...............................
%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%%%%%%%%%%%(##((#%((//(((..............(%%%%%%%%###((/**,..............................
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%%%%%%%%%%%&&&&&&&&&&&&*/(##(((......*%%%%%%%###((//***,.............................
%%%%%%%%&%%%&&&&&&&&&&&%%%%%%%%%&&&&&%%%%%%%%&&&&&&&&&&&&&&&#/##%%#####(,%%%%%%###((((////*,,...........................
%%%%%%%%%%%%%%%%%%%&%&&&&&&&&%%%%%&&%%%&&%%%&&&&&&&&&&&&&&&&&**%%%##%###%%%##########((((///****//*////**,*,,,/////(((((
%%%%%%%%%%##%%%%%%###%##%%%&&&&&&&%%%%%%%#%&&&&&&&&&&&&&&&&&%*(#%%#######*#%%%%%#######((((((((/(((/(((((((*//((((((((((
%#%%%%%%%%%%%%%%%%%%%%%%&&%%&&%&&%%%%###((&&&&&&&&&&&&&&&&%%((%%##%%%%%%%#/#%%%%%%%########((((((((((#########(((#######
%%%%%%%%%%%%%%%%%%%%%%%%%%%&%&&&&&%&%%%#/%&&&&&&&&&&&&&&&%###(&%%%#%%%%%%%%%%(/%%%%%%#######################%%%###(#####
%%%%%%%%%%%%%%%%%%%%%%&&&%&&%%%%%%%%%%%%/%&&&&&&&&&&&&&&%**/#%&&%%%%%%%%%%%%%%%(%%%%%%%%%%###########%%%%%%%%%%%%%%%%(%#
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&(//**%%%&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%%&&&&&&&&&&&&%#*##*/%%%%&&&&&&&%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%#%&&&&&&%&&&&&%###,*/*%&&%%&%%%%%%%%%%%%%%%%%%%%(%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
#%&%#%%%##%%#%%%%%%##%#%%%%%%%%%%%%%%%*&&&&%&%%%&&%%%%%%#*,*%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%
##%%##############(###((((#((#(((#((#(((&&&&%&%%%&%%%%%%%%#*(%(/(#####%%%#%/#%&&&&&%%%%%%%%#%%%%%%%%%&%%%%%%%&&&&&&&%%%%
############(((((((((((((#(((((((((((((((%&%###%%%%%%%%%%%%%%*(%%%%.(((/*%%&&&&&&&%###(####(&&&&&&%%%&%%%%&&&&&&&&&&&&%%
#%#################%#%%#%##%####(#(#(##(%%%%##########%&%%%%%%%%%%%#.*%%&&&&&&&&&(#(((###((&&&&&&&&(&%&&&&&&&&&&&&&&&&&&
%%%#%#%#%%#%#%#####((###(#####((#(######%%%%%%#######%%%%##%%%%%%%%%%%%%%%%%&#((((((((((&&&&&&&&&&&#&&&&&&&&&&&&&&&&&&&&
%%%%%%#%%%%%%%%%#######((#####((##(((##%%%%%%%%%####%%%%%#####((//##(((%%%%%%#((((#%&&&&&&&&&&&&%%#&&&&&&&&&&&&&&&&&&&&&";
        string _87 = @"
*/*///////////**********************,**,*////*,,*/***,,,,,,,*,,,,,****************************************//////////////
***********/*****///*,*******************,,,,,,***,,,,,,,,,,,,,,,,,,*****,,*****************************************////
*******************,,*********//**,**,,,,****,,,,,,,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************
********,*************,,,,*,,,,,,,**************,,,,,*,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
%%%%%%#(***,,,,,,,,,,,,,,.,,,..,,,,,***,..,,,.,,,..,,,,...,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
%%%%%%%%%%%%%%%*.,,,,,,,,,,..,,,,,,,,,,,,,,,......,,,,,,,,,,.............................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%(..,,................................................................................,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%&&%%%%%#........................................................................................,,,,
%%%%%%%%%%%%%%%%%%%&&&&&%%%&&&&%%,........................................./%%%%%%%###/.................................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&%%%%%%%%(######(*........................*%%%%%%%%%###((/*...............................
%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%%%%%%%%%%%(##(%&&%%%%(//.............,#%%%%%%%%###((/**,..............................
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%%%%%%%%%%%&&&&&&&&&&&&#(*((((/......%%%%%%%%###((//**,..............................
%%%%%%%%&%%%&&&&&&&&&&&%%%%%%%%%&&&&&%%%%%%%%&&&&&&&&&&&&&&&&#/#%%%####/#%%%%%%##(((((////*,,,..........................
%%%%%%%%%%%%%%%%%%%&%&&&&&&&&%%&%%&%%%%&&%%%&&&&&&&&&&&&&&&&&#,(%%######%%%##########((((///*/**///////**,*,,*////((((((
%%%%%%%%%%##%%%%%%######%%&&&&&&&&%%%%%%%%%&&&&&&&&&&&&&&&&&%//#%%######*,%%%%%%%######(((((((((((((((((((/*/(((((((((##
%%%%%%%%%%%%%%%%%%%%%%%%&&%%&&%&&%%%####((#&&&&&&&&&&&&&&&%#/(#%%(%%%%%%%(#%%%%%%%%#########(((((((((#########*(########
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&%&%%%#(#&&&&&&&&&&&&&&&%%###%%%%%%%%%%%%%%%(/%%%%%%######################%%%%###/#####
%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%&%%%%%%%%%(%&&&&&&&&&&&&&&&(,*%#&%%%%%%%%%%%%%%%%%%%%%%%%%%%###########%%%%%%%%%%%%%%%%(%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%%&&&&&&&&&&&&&&%/*,*#%%&%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%%&&&&&&&&&&&&&%(*#/*%%%%&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&%%&&&&&%%#/***#&&%%&%%%%%%%%%%%#%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%#%#%#%%%%%%%%%%##%%%(%%%%%%%%%%%%%(#&&&&%&&%%&&%%%%%%((,%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%
##%##########(#######(#((#(((#(((#((#(#(%&&&%&&%%%&%%%%%%%%**#%*(#####%#%#%(%&&&&&&%%%%%%%%%%%%%%%%%%&%%%&&%%&&&&&&%%%%%
############((((((((#((#(###(((((((((((((%%%%######%%%%%%%%%%#.%%%%.#((*/%%&&&&&&&%########(%&&&&&%%%%%%%%&&&&&&&&&&&&%%
%#################%%%%%%%#%%#(##(#(#(####%%%%#########%%%%%%%%%%%%%(.#%%&&&&&&&&&(((((###((%&&&&&&&#%%%&&&&&&&&&&&&&&&&&
#%#%%%%#%%#%#%#%##(((###(#(#####(#####(#%%%%%%########%%%%%%%%%%%%%%%%%%%%%%&%((((((((((%%&&&&&&&&&%&&&&&&&&&&&&&&&&&&&&
%%%%%%%%%%%%%%#%##%####%######(((##((#%%%%%%%%%%%%%%%%%%%(((((((/((#((#%%%%%((((((/#&&&&&&&&&&&&&#%&&&&&&&&&&&&&&&&&&&&&";
        string _88 = @"
*/////////////*********,************,,*,,////*,,*/***,,,,,,,*,,,*,****************************************//////////////
*****************///***,*****************,,,,,,***,,,,,,,,,,,,,,,,,,*****,,,,***************************************////
*******************,,*********///******,,,***,,,,,,,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************
********,**************,,,,,,,,,,,**************,,.,,,,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
%%%%%%%#***,,,,,,,,,,,,,,.,,,..,,.,,*,*,..,,,.,,,...,,,,..,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
%%%%%%%%%%%%%%%/.,,,,,,,,,,..,,,,,,,,,,,.,,.......,,,,,,,,,,.............................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%/....................................................................................,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%&&%%&%%%........................................................................................,,,,
%%%%%%%%%%%%%%%%%%%&&&&&&%%&&&%%%,........................................,#%%%%%%%###/.................................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&%%%%%%%%((####(#(*.......................(%%%%%%%%%###((/*...............................
%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%%%%%%%%%%%####%&&&&&&#((, ...........*%%%%%%%%####((/**,..............................
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%%%%%%%%%%%&&&&&&&&&&&&&#//(((/......%%%%%%%%###((//**,..............................
%%%%%%%%&%%%&&&&&&&&&&&%%%%%%%%%&&%&&%%%%%%%%&&&&&&&&&&&&&&&&%/#%%%####/%%%%%%%##(((((///***,,..........................
%%%%%%%%%%%%%%%%%%%&%&&&&&&&%%%&%%&%%%%&&%%%&&&&&&&&&&&&&&&&&%,/%%%%####%%%##########((((///*/**///////**,*,,*////((((((
%%%%%%%%%%##%%%%%%######%%&&&&&&&&%&%%%%%%%&&&&&&&&&&&&&&&&&#//#%%######,,%%%%%%%######(((((((((((((((((((///(((((((((##
%%%%%%%%%%%%%%%%%%%%%%%&&&%%&&%&&%%%####((#&&&&&&&&&&&&&&&%#/(#%%#%%%%%%%##%%%%%%%%#########(((((((((#########*(########
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%&&&&%%##%#(#%&&&&&&&&&&&&&&%%###%%%%%%%%%%%%%%%((%%%%%%######################%%%%###(#####
%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%&%%%%%%%%%#%&&&&&&&&&&&&&&&#**##%&%%%%%%%%%%%%%%%%%%%%%%%%%%###########%%%%%%%%%%%%%%%#(%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%#&&&&&&&&&&&&&&%(/,*(%%&%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%%%%%&&&&&&&&&&&&&%#*(/*%%%%&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%&&&&%%#(***(%&%%%%%%%%%%%%%%(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%&##%###%%%%%%%%%%###%%(%%%%%%%%%%%%%(#&&&&%&&%%&&%%%%%%(/*%%%%%#%%%%%%%%%%(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%
##%##########(#######(#((#(((#(((#((#(#(%&&&&%&%%%&%%%%%%%%*,(%,###(##%#%#%#%&&&&&%%%%%%%%%%%%%%%%%%%&%%&&&%%&&&&&&&&&%%
############((((((((#((#(##((((((((((((((%%%%######%%%%%%%%%%%.#%%%,#((*/%%&&&&&&&%####%###(%&&&&&%%%%%%%%&&&&&&&&&&&&%%
%#################%%%%%%##%%#(##(#(#(##(%%%%%#########%%%%%%%%%%%%%(.%%%&&&&&&&&&/((((###((&&&&&&&&%%%%&&&&&&&&&&&&&&&&&
%%#%%%#%%%###%#%##(/#(##########(#####(#%%%%%%########%%%%%%%%%%%%%%%%%%%%%&&%(((((/((((%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
%%%%%%%%%%%%%%#%##############(((#((##%%%%%%%%%%%%%%%%%%%##(((((/((((##%%%%%((#((((#%&&&&&&&&&&&&#%&&&&&&&&&&&&&&&&&&&&&";
        string _89 = @"
//////////////******,*,**************,*,,////*,,*/***,,,,,,,*,,,*,****************************************//////////////
*****************///*,*,*****************,,,,,,***,,,,,,,,,,,,,,,,,,*****,,,,***************************************////
*******************,,*********///*,***,,,****,,,,,,,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************
********,**************,,,,,,,,,,***************,,.,,,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
%%%%%%%/***,,,,,,,,,,,,,,,,,,..,,.,,*,*,..,,,.,,,...,,,,..,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
%%%%%%%%%%%%%%%,.,,,,,,,,,...,,,,,,,,,,,.,,.......,,,,,,,,,,.............................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%&,....................................................................................,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%&%%%&%%%........................................................................................,,,,
%%%%%%%%%%%%%%%%%%%&&&&&&%%&&&&%&.........................................*%%%%%%%%##(*.................................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&%%%%%%%#((####(/,.......................%%%%%%%%%%###(//*...............................
%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%%%%%%%%%%%####&&&&&&&&&(,............*%%%%%%%%####((/**,..............................
%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%%%%%%%%%%%&&&&&&&&&&&&&&%//((/.....,%%%%%%%###(((//**,..............................
%%%%%%%%&%%%&&&&&&&&&&&%%%%%%%%%&&%&&%%%%%%%%&&&&&&&&&&&&&&&&&(/#%%###(,%%%%%%%##(((((///***,,..........................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%%&%%&%%%%&&%%%&&&&&&&&&&&&&&&&&&#*#%%%###/%%%##########((((///*/**/*//////*,*,,*////((((((
%%%%%%%%%%##%%%%%%######&%&&&&&&&&%&%%%%%%#%&&&&&&&&&&&&&&&&%(/(#%######**%%%%%%%######(((((((((((((((((((*/((((((((((##
%#%%%%%%%%%%%%%%%%%%%%%&&&%%&&%&&%%%#######%&&&&&&&&&&&&&&&#((#%%#%%%%%%((#%%%%%%%%%########(((((((((########(((########
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%&&&&%%##%####&&&&&&&&&&&&&&&%#((#%%%%%%%%%%%%%%##%%%%%%%#####################%%%###(%#####
%%%%%%%%%%%%%%%%%%%%%&&&%&&%%%&%%%%%%%%%%%%&&&&&&&&&&&&&&&(*/#%%%%%%%%%%%%%%%%#%%%%%%%%%%%###########%%%%%%%%%%%%%%%(%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%%%&&&&&&&&&&&&&&%#/**#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%&&&&&&&%%&&&&&%#//*(%%%&&&&&&&&%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%&&&&&%#(//*#&%&%%%%%%%%%%%%(%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%##%%##%%#%%%%%%#%%#%%#%%%%%%%%%%%%%##&&&&&&&&%&&&%%%%%%(*#%%%%#%%%%%%%%%%(%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%&&&&&%
##%##################(#((((((#((###(((#((%&&&%%%%%%&%%%%%%%%,*#/(#####%#%#%%&&&&&&%%%%%%%%%%%%%%%%%%%&%%%%%%%&&&&&&&&&%%
#########(#(((((((((((#(#(/(((((#((((((((%%%%#######%%%%%%%%%%(*%%%*((//(%%&&&&&&&#####%###%%%%%&%%%%%%%%%&&&&&&&&&&&&%%
%#######%#######%#%%%%#%##%#####(##((###%%%%%%#########%&%%%%%%%%%%**%%%&&&&&&&&&/(((#####(&&&&&&&%%%%%&&&&&&&&&&&&&&&&&
%%#%#%#%%###%##%#######(#(###(#((#####(#%%%%%%%#######%%%%%%%%%%%%%%%%%%%%&&&&#(/((/(((#%&&&&&&&&&%&&&&&&&&&&&&&&&&&&&&&
%%%%%%%%%%%%%%%##############((##(((###%%%%%%%%%%%%%%%%%%%((((((/(((##%%%%%#((#((((((%&&&&&&&&&&&#&&%&&&&&&&&&&&&&&&&&&&";
        string _9 = @"
***************************//////////////////////////((((((((((((((((((######################################%%#%%%%%%%%
,,,*******************************////////////////////////////(((((((((((((((((((((((((#################################
,,,,,,,,,,,,,,,,,,,****************************************////////////////(((((((((((((((((((((((((((((################
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**********************************///////////////////////(((((((((((((((((((((((((((((((((
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************///////////////////////////////((((((((((((((((((((
.........,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************************//////////////////////////////(((((((((
...........................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****************************///////////////////////////////
.....................................,,,,,,,,,,,*%&#*,,,,,,,,,,,,,,*******************************//////////////////////
#####(,......................................,#&&&&&&&#,,,,,,,,,,,,,,,,,,,,,*********************************///////////
#############%(.............................*#&&&&&&&&&#,,,,,,,,,,,,,,,,,,,,,,,,**********************************//////
#######%%%%%%%%%%%%%%%%%%%%................/#%%&&&&&&&(,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#/,.....,/*#&&&&&&&%*.....,,,,,,,,,,,,,,,,,,,,,,,,,************************************
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(//(%&&&&&&&&%*.......,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************
#%%%%%%%%%#######%%%%%%%%%%&&&%&%%%%%#(//#&&&&&&&&&&&%%%%%%%%%%%#,,,,,,,,,,,,,,,****************************************
#############%%%#%%%%#########%%%&&%%#//#&&&&&&&&&&&&%%###%%%%&&&&&&&&&&&&&&%%%%%%%#((/*********************************
###############################%%%%%%%/*(&&&&&&&&&&&&#######%%%%%%&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%&%%%%%%%(//*//**////
####%%%%%%%#%########################(*/%&&&&&&&&&&&&%%%%%%##%&&&&%%##%%%%%&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%
%%%%%%%%#####%%##########%%%########/,*(%&&&&&&&&&&&&%##/(%&@@&&####%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%#####%%%%#%#########%%###%%%%%/,/(%&&&&&&&&&&&&&&&(*#&&&@@@%%%##%#############%##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&
%%%%%%%%%%%%%&%%%%%%%%%%%%%#%#%%%(**/#%&&&&&&&&&&&%&&&%(#(%&&&&&&&&&%%%%%%#%%%%#######%###%#%#######%%%%%%%%%%%%%%%%%%%%
###%###%%#%#####%########%%###%%((//%%&&&&&&&&&&&&%&&&&#*/*&&&&&&&&&&&&&&%&&%%%&&#%%%%%%%&&&&&&&%##%%#######%%%%%%%%%%%%
((((((((((((((((((((((((((((((((/((/&&&&&&&&&&&&&&%%%&&&&%%%%&&&&&%%###&&%%%%%&&&%%%%%%%%#&&&%#%%%%#%%%%%##%%%#%%%%%%%#%
#######(###%####(#######%####(#((#%#&&&&&&&&&&&&&&%%%%#((%%%&%&&&&%##(((#((#(##((#(##((##(((((####(##########(#########%
#####################%##########(#%#%&&&&&&&&&&&&&&%#%#%%%%%%%%%%%%%##(##########(###(####%#%%###########%%##%#%%%%%#%%%
%%%%%%%%%######%####((###########%#(#&&&&&&&&&&&&&%%###%#%#%&%%%%%%%%###((####(#%%%%%%%#####%##############%#########%#%
&%%%%&&&%%%%&%%####(##%#####((###%%##&&&&&&&&&&&&&%%######%%%%%%%%%%%##%%%%&%%%&%%%%%%%%%%%#%#%%%%###%%#%%%#####%#%#%%%%
&&&&&&&&&&&&&&&&%%##%%%%&%%%%#%%%%%##&&&&&&&&&&&&&&&%#####%/%%%%%%%%%%%&%#%%#%%%%&%%%%%%%%%%#%%%%%%%#%%%#%%%%%%%%%%#%%%#";
        string _90 = @"
//////////////******,*,*************,*,,*///*,,,*/***,,,,,,,*,,,*,*****************************************/////////////
*****************///,,*******************,,,,,,**,,,,,,,,,,,,,,,,,,,*****,,,,***************************************////
*******************,,********///**,*,,,,,****,,,,,,,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************
*******,**************,,,,,,,,,,,***************,,.,,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
%%%%%%#****,,,,,,,,,,,,,,,,,,..,,,,****,..,,,.,,,..,,,,...,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
%%%%%%%%%%%%%%#..,,,,,,,,,,..,,,,,,,,,,,,,,.......,,,,,,,,,,...............................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%,......................................................................................,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%&%%%&%%#..................................................,.....................................,,,,
%%%%%%%%%%%%%%%%%%&&&&&&%%%&&&%%&.........................................#%%%%%%%%##(,.................................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&%%%%%%#######(*...,,...................%%%%%%%%%%###((/*...............................
%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&%%%%%%%%%%####&&&&&&&&&&#,...........(%%%%%%%%####((/**,..............................
%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%%%%%%%%%%%%&&&&&&&&&&&&&&&%//(( ....(%%%%%%%###(((//**,..............................
%%%%%%%%&%%%&&&&&&&&&&&%%%%%%%&&&&&&&%%%%%%%%%&&&&&&&&&&&&&&&&&*/#%###(*%%%%%%%##(((((///***,,..........................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%%&%%&%%%%&&&&%%&&&&&&&&&&&&&&&&&%*/##%%##(%%%##########((((///*/**/*//////***,,/////((((((
%%%%%%%%%%##%%%%%%###%##&%&&&&&&&&%&%%%%%%#%%&&&&&&&&&&&&&&&&(*/#######(*#%%%%%%%#######((((((((((((((((((///(((((((####
##%%%%%%%%%%%%%%%%%%%%%&&&&%&&&&&%%%%#######&&&&&&&&&&&&&&&&(((###%%%%%%(*%%%%%%%%%#########(((((((((#######(*((########
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&%&##%%###%&&&&&&&&&&&&&&&%/((%%%%%%%%%%%%%%##%%%%%%%#####################%%%###(%#####
%%%%%%%%%%%%%%%%%%%%%&&&%&&%%%&%%%%%%%&%%%%&&&&&&&&&&&&&&%&#*/#%%%%%%%%%%%%%%%#%%%%%%%%%%%%##########%%%%%%%%%%%%%%##%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%%%&&&&&&&&&&%&&%&%#/**#%%%%%%&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%&&&&&&&&%%%&&&&%#/**%%%&&&&&&&%%%%%%(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%%%&&&&&%#/(*(%%&%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%#%%%#%%%#%%%%%%#%%%%%%%%%%%%%%%%%%%#%%&&&&&&&&&&&&&&%%%%/*%%%%#%%%%%%%%%%#%%%%%%%%%%%%%(%%%%%%%%%%%%%%%%%%%%%%%&&&&%%
#%%%#############(###(#((((((#((###(/(#((#&&&&%%%%%%&&%%%%%%%,(#*#####%#%#%#%&&&&&%#%%%%%%%%%%%%%%%%&&%%%&&%%&&&&&&&&&%%
###########((((((((##(((#(/(((((#((((((((#%%%%#######%%%%%%%%%#,(%%(*(//#%%&&&&&&&(####%###%%%%%%&%%%%%%%&&&&&&&&&&&&&%%
########%########%%#%%#%#%%#####((#((##(#%%%%%##########%%%%%%%%%%%*(%%%&&&&&&&&&((((######%&&&&&&%%&&%&&&&&&&&&&&&&&&&&
%%%%%%#%%#%#%(###########(#%#(##(#######%%%%%%%########%%%%%%%%%%%%%%%%#%&&&&&%/(((((((#%&&&&&&&&&%&&&&&&&&&&&&&&&&&&&&&
%%%%%#%%%%%%%%########%##########((((((%%%%%%%%%%%%%%%%%%%#(((((/(##%%%%%%%##(((((#(/(&&&&&&&&&&&%&%%&&&&&&&&&&&&&&&&&&&";
        string _91 = @"
//////////////****/***,*************,*,,*////,,,*/***,,,,,,,*,,,*,*****************************************/////////////
*****************///*,*******************,,,,,,**,,,,,,,,,,,,,,,,,,,*******,,***************************************////
*******************,,********///**,*,,,,,****,,,,,,,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************
*******,**************,,,,,,,,,,,***************,,,,,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
%%%%%%(****,,,,,,,,,,,,,,,,,,..,,,,****,..,,,.,,,..,,,,...,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
%%%%%%%%%%%%%%#..,,,,,,,,,,..,,,,,,,,,,,,,,.......,,,,,,,,,,...............................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%/......................................................................................,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%&&%%%&%%(.................................................,,.....................................,,,,
%%%%%%%%%%%%%%%%%%&&&&&&%%%&&&%%&.........................................#%%%%%%%%##(,.................................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&%%%%%%###(###(*..*%&#**...............*%%%%%%%%%%###((/*...............................
%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&%%%%%%%%%%####&&&&&&&&&&&&,... ......#%%%%%%%%%###((/**,..............................
%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%%%%%%%%%%%%%&&&&&&&&&&&&&&&%///.....#%%%%%%%###(((//**,..............................
%%%%%%%%&%%%&&&&&&&&&&&%%%%%%%&&&&&&&%%%%%%%%%&&&&&&&&&&&&&&&&&&,/%###((%%%%%%%##(((((////**,,..........................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%%&%%&&%%%&&&&%%&&&&&&&&&&&&&&&&&&(*(#%###/%%%##########((((///*/**/*//////***,,/////((((((
%%%%%%%%%%##%%%%%%###%##&%&&&&&&&&%&%%%%%%%%%&&&&&&&&&&&&&&&&%#/(######*,#%%%%%%%#######((((((((((((((((((/*/(((((((####
##%%%%%%%%%%%%%%%%%%%%%&&&&%&&&&&%%%%#######&&&&&&&&&&&&&&&&&(/(##%%%%%%#/%%%%%%%%%#%#######(((((((((#######(,((########
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%&#%%####%&&&&&&&&&&&&&&&&%/(#%%%&%%%%%%%%%(#%%%%%%%#####################%%%###%%#####
%%%%%%%%%%%%%%%%%%%%%&&&%&&&%%&%%%%%%%&%%%%%&&&&&&&&&&&&%#&&#*((%%%%%%%%%%%%%%%%%%%%%%%%%%%##########%%%%%%%%%%%%%%(%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%%%%&&&&&&&&&%&&&&&#/(*/%%%%%%&%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%/%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%&&&&&&&&%%%&&&&&%#**#%%&&&&&&&%%%%%%(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&%%%%&&&&&%(*#*%%%&%%%%%%%%%%%%%%%%%%%##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%(%%%#%%%#%%%%%%##%%%#%%%%%%%%%%%%%%#%%&&&&&&&&&%&&&&%%%%%,%#%%#%%%%%%%%%%%%%%%%%%(%%%%#%%%%%%%%%%%%%%%%%%%%%%%%&&&&%%
#%%#########%####(##((#(((#((#((###(/(#((#%&&&&%%%%%&&&%%%%%%((#.#####%#%%%%%&&&&&%/%%%%%%%%%%%%%%%%&&%%%&&%%&&&&&&&&&%%
###########((((((((##(((#(/(((((#((((((#(#%%%%########%%%%%%%%%#,%%%.(//%%%&&&&&&&(####%###%%%%%&&%%&%%%%&&&&&&&&&&&&&%%
%################%%%%%%%#%%######(#((#(((%%%%%%#########%%%%%%%%%%%/(%%%&&&&&&&&%(((((#####%&&&&&&%%&&%&&&&&&&&&&&&&&&&&
%%%%%%#%%#%#%(###%#######(%%#(##(#######%%%%%%%%#######%%%%%%%%%%%%%%%%#%&&&&&%((((((((#%%&&&&&&&&%&&&&&&&&&&&&&&&&&&&&&
%%%%%%%%%%%%%%#######%########(#%/(((((%%%%%%%%%%%%%#%%%%%%(((((/(#%%%%%%%#(#(((((#((/&&&&&&&&&&&%%%%&&&&&&&&&&&&&&&&&&&";
        string _92 = @"
//////////////****/***,*************,*,,*////,,,*/***,,,,,,,*,,,*,*****************************************/////////////
*****************///*,*******************,,,,,,**,,,,,,,,,,,,,,,,,,,*******,,***************************************////
*******************,,********///**,*,,,,,****,,,,,,,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************
*******,**************,,,,,,,,,,,***************,,,,,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
%%%%%%(****,,,,,,,,,,,,,,,,,,..,,,,****,..,,,.,,,..,,,,...,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
%%%%%%%%%%%%%%#..,,,,,,,,,,..,,,,,,,,,,,,,,.......,,,,,,,,,,...............................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%/......................................................................................,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%&&%%%&%%/.................................................,,,,,..................................,,,,
%%%%%%%%%%%%%%%%%%&&&&&&%%%&&&%%&........................................*%%%%%%%%%##(,.................................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&%%%%%%(##(###(,..#&&%##(,.............(%%%%%%%%%%###((/*...............................
%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&%%%%%%%%%%####&&&&&&&&&&&&#,........,%%%%%%%%%%###((/**,..............................
%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%%%%%%%%%%%%%&&&&&&&&&&&&&&&&#//.....%%%%%%%%####((//**,..............................
%%%%%%%%&%%%&&&&&&&&&&&%%%%%%%&&&&&&&&%%%%%%%%&&&&&&&&&&&&&&&&&&(*####*%%%%%%%%##(((((////**,...........................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%%&%%&&%%%&&&&%%&&&&&&&&&&&&&&&&&&(*/####(#%%%##########((((///*/**/**/////,**,*/////((((((
%%%%%%%%%%##%%%%%%#%%%##&%&&&&&&&&%&%%%%%%%#%&&&&&&&&&&&&&&&&&#/(######,,%%%%%%%%#######(((((((((((((((((/**/(((((((((##
##%%%%%%%%%%%%%%%%%%%%%&&&&%&&&&&%%%%###(###&&&&&&&&&&&&&&&&&%(*##%%%%%((#%%%%%%%%%%%#######(((((((((#######*/((########
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&%&#%%#%##%&&&&&&&&&&&&&&&&&#/(%%%&%%%%%%%%%(%%%%%%%%######################%###/#######
%%%%%%%%%%%%%%%%%%%%%&&&%&&&%%&%%%&%%%&%%#%%%&&&&&&&&&&&&%#&%(*(#%%%%%%%%%%%%#%%%%%%%%%%%%%##########%%%%%%%%%%%%%##%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%%%%&&&&&&&&&&&%&&&%%*(*/%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%/%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%%%#%%&&&&&&&&%%%&&&&&&#*/(%&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%&&&&&&&&%%%%&&&&&%(//#%%&%%%%%%%%%%(%%%%%%%%(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%###%%%#%%%%%%%%%%%%%%#%%&&&&&&&&&%%%&&&&%%%.,#%%#%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%%
#%%######%##%####(##((##((#(##(((##(((#((##&&&&%%%%%&&&&%%%%%#.%,####%%%%%#%&&&&&&%%%%%%%%%%%%%%%%%%&&%&&&&%%&&&&&&&&&%%
###########((((((#((#(((#(((((#(#(((((((((%%%%%########%%%%%%%%%.%%%.(*/%%&&&&&&&%########(%%%%%&&%&&%%%&&&&&&&&&&&&&&%%
########%########%%%%%%%%%%####(((#((#(#(%%%%%%#########%%%%%%%%%%#.%%%%&&&&&&&&%#(((####(%&&&&&&&%%&&%%&&&&&&&&&&&&&&&&
%%%%%#%%%##%#######%%#(####%##&#########%%%%%%%%#######%%%%%%%%%%%%%%%#%%&&&&&%/((((((((*#&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
%%%%%%%%%%%%%#%#################(#(#(#(%%%%%%%%%%%%%#%%%%%%((((//#%%%%%%%##(((((((#((/&&&&&&&&&&&#%%%&&&&&&&&&&&&&&&&&&&";
        string _93 = @"
//////////////*********************,,*,,*////,,**/**,,,,,,,,*,,**,*****************************************/////////////
**********/****////**********************,,,,,,**,,,,,,,,,,,,,,,,,,,************************************************////
******************,,*********//*****,,,,,****,,,,,,,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************
*******,*************,,,,*,,,,,,,***************,,,,,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
%%%%%%*,***,,,,,,,,,,,,,.,,,,..,,,*****,..,,,,**,..,,,....,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****
%%%%%%%%%%%%%%,..,,.,,,,,,,.,,,,,,,,,,,,,,,........,,,,,,,,,...............................,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%/,.,,,....................................................................................,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%&&%%%%(%,................................................,,,,,...................................,,,,
%%%%%%%%%%%%%%%%%%&&&&&&%%%&&%%%#........................................#%%%%%%%%%##(..................................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&%%%%%###/,/(/....%&&&&&%(,............%%%%%%%%%%%###(/*................................
%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&%%%%%%%%%####(&&&&&&&&&&&&&(......../%%%%%%%%%%###((/**...............................
%%%%%%%%%%%%%%%&&%%%%%%%&&&&&&&&&&%%%%%%%%%%%%%&&&&&&&&&&&&&&&&%/* .../%%%%%%%%####((//**,..............................
%%%%%%%%&%%%&&&&&&&&&&&%%%%%%&&&&&&&&%&%%%%%%%&&&&&&&&&&&&&&&&&&&*###(/%%%%%%%%##(((((///*,,,...........................
%%%%%%%%%%%&&&&&%&&&&&&&&&&&&%%%%%&&%%%&&&&%%&&&&&&&&&&&&&&&&&&#(*#%%#/%%%%########(((((////****/*,////****,*/////((((((
%%%%%%%%%%#%%%%%%%%%%%%#%%&&&&&&&&%&&%%%%%%#%&&&&&&&&&&&&&&&&&%/((####,*(%%%%%%%%######(((((((((((/(((////,//(((((((((##
#%%%%%%%%%%%%%%%%%%%%%%&&&%%&&&&%%%%%###(###&&&&&&&&&&&&&&&&&&(/(#%%%%%((%%%%%%%%%%%#######((((((((((###(((/((((########
%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&%%%%%%###%%&&&&&&&&&&&&&&&&&(/(%%%%%%%%%%%%#%%%%%%%%########################/(#%######
%%%%%%%%%%%%%%%%%%%%%&&&%%&%%&%%&&&&%%&%%%%%&&&&&&&&&&&&&&&/&%(*/%%%%%%%%%%%#%%%%%%%%%%%%%%###########%%%%%%%%%%%/#%%%%%
%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&%(#&&&%*//*#%%%&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%%%%#%%&&&&&&&&%%%&&&%&&%%(/(#%%&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%
%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%%&&&&&&%#(*%&&%%%%%%%%%#%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%#%%%%%%%%%&%%%#%#%%%%%%%%%%%%%%%%%%%###&&&&&&&&&%%%%&&&&%**#%%#%%%%%%%%%%%%%&%%%(%%%#%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%%
%%%######%#################((((##((####((##&&&&%%%&&&&&%%%%%%%*%.####%%%%%#&&&&&&%(%%%%%%%%%%%%%%%%&&&&&&&&%%&&&&&&&&&%%
##########((((((#(##(((#((((((#(#((((((#((%%%%%########%%%%%%%%%*%%%./(%%%&&&&&&&(########%%%&&&%%%&%%%&&&&&&&&&&&&&&%%%
#######%##########%#%#%%%%##(#(((((##((#(%%%%%%#########%%%%%%%%%%.#%%%%&&&&&&&&/#(((###(*&&&&&&&%%&&%%&&&&&&&&&&&&&&&&&
%%%%#%%%##%###%%##%%#(%##%#(##%##(######%%%%%%%%########%%%%%%%%%%%%%#%%%&&&&&%(((((((((*&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
%%%%%%%%%%#########(######(((#//%(%#(((%%%%%%%%%%%%%#%%%%%%((/((%%%%%%%%%##((#(((((((%&&&&&&&&&&&&&%&&&&&&&&&&&&&&&&&&&&";
        string _94 = @"
//////////////***/*****************,,*,,////*,,****,,,,,,,,,,,,*,******************************************/////////////
**********/****//************************,,,,,*,,,,,,,,,,,,,,,*,,,,****,,*******************************************////
*****************,,,*********//*****,,,,*****,,,,,,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********************
******,**************,,,**,,,,,,************,***,,,,,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************
%%%%#(,***,,,,,,,,,,,,,,.,,,..,,,,****,,.,,,,,**,..,,....,,,,..,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***
%%%%%%%%%%%%%/...,..,,,,,,.,,,,.,,,,,,,,,,,........,,............,..............................,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%,...,,...,,,..............................................................................,,,,,,,,,,,
%%%%%%%%%%%%%%%%&&&%%%%%**(.................................................,,,,......................................,,
%%%%%%%%%%%%%%%%%&&&&&&%%%%&&&%%........................................,%%%%%%%%%###*..................................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&%%%%#(/*.........#&&&%&&#............*%%%%%%%%%%%##((/*................................
%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&%%%%%%%%%####(%&&&&&&&&&&&&#.......,#%%%%%%%%%###((//*,...............................
%%%%%%%%%%%%%%%&%%%%%%%%&&&&&&&&&&%&%%%%%%%%%%%&&&&&&&&&&&&&&&&%/.....#%%%%%%%%###(((/**,,..............................
%%%%%%%%&%%%&&&&&&&&&&%%%%%%&&&&&&&&&%&%%%%%%%&&&&&&&&&&&&&&&&&&&/###*#%%%%%%%%###(((//***,,............................
%%%%%%%%%%%&&&%&&&&&&&&&&&&&&%%%%%&&%%%&&&&%%&&&&&&&&&&&&&&&&&&%#*#%#(#%%%%########(((((///******,,*//************/(((((
%%%%%%%%%%#%%%%%%%%%%%%%%%&&&&&&&%%&%%%%%%%%%&&&&&&&&&&&&&&&&&&/((###/,*%%%%%%%#######(((((((///(//((//*,,.//((((((((((#
##%%%%%%%%%%%%%%%%%%%%%&&&%&&&%&%%%%%######%&&&&&&&&&&&&&&&&&&(/(#%%%#(/#%%%%%%%%%%########(((((((((((((((/((((((#######
%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&%%%%#%###(%%&&&&&&&&&&&&&&&&&(*/#%%%%%%%%%%#%%%%%%%%#########################*#########
%%%%%%%%%%%%%%%%%%%%%&&&%%&%%&%%&&&%%%%%%%%%&&&&&&&&&&&&&&%*#&(*/#%%%%%%%%%%%%%%%%%%%%%%%##############%%%%%%%%##(%%%%%#
%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%&%%&&%%%%%%%&&&&&&&&&&%#/#%&&&*/**(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%##%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%%%%#%%&&&&&&&&%%%&&%%%%&%#(/(#%&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#(%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%%%&%&&&%#((#%%%%%%%%%%%(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%#%%%%%%%%%%%%%%#%%%#%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%%%%&&%%,,%%##%%%%%%%%%%%%&&%%##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%#%###%%#%####(###(###(####(#(#%(#######%&&&&%%&&&&&&%%%%%%/%**#(#%%%%%%%%%&&&&##%%%%%%%%%%%%%%%%&%%&&&%%%%&&&&&&&%%%%
########(#(((((##(##(((#((((((#(#(((((((((%%%%%#######%%%%%%%%%,%%%*/((%%&&&&&&&#(###%####%%%%%%%%%%%%%&&&&&&&&&&&&%%%%%
##################%#%##%%##(#((((((##((((%%%%%%#########%%%%%%%%%**%%%%&&&&&&&&%/((((###((&&&&&&%&&&%%%&&&&&&&&&&&%%%%%%
%%#%#%%##%%##%###%#%#########%%##(######%%%%%%%%########%%%%%%%%%%%%(#%%&&&&&&#((((/(#((/&&&&&&&&&&&&&&&&&&&&&&%%%&&&&&%
%%%%%%%%%%#%#############((#(((##(#(((#%%%%%%%%%%%%%%#%%%%%/(((#%%%%%%%%%#((/(/(((((/%%&&&&&&&&&&&&%&&&&&&&&&&&&&&&&&&&%";
        string _95 = @"
//////////////**///////////**,,,,,,**,///*****//**,****,,,,,,*************************************//////////////////////
****////**////*********,,***************,,**,,,,,,**,,,,,,,,,,,************************************************/////////
************/******////*********************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***,,**********************
******************,,,,,,,,**************,,,,,*,,,,,*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***************
%%,,*,**,,****,,,,,,,,,,,,.,,,,**,.,**********,,,,...,,,*,,,,,.......,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********
%%%%%%%%%%%,,,.,,,,..,,,,,.,,,,...,,,,,,......,....,,,,,,.......,,,,,,,..................,,,,...,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%,,,,,,,,,...............................................................................,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%%.....................................................,,...................................,,,,,,,,
%%%%%%%%%%%%%%%%%&%%%%%%%&%%%%.........................................,%%%%%%%%%%##....................................
%%%%%%%%%%%%%%%%%&&&&&&&&&&%%&&&&%%,................#%%/.............(%%%%%%%%%%%###(/..................................
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&%%%%%%%#####(((&&&&&&&&&&&&,......*%%%%%%%%%%%###((//*................................
%%%%%%%%%%%%%%&%%%%%%%%&&&&&&&&&&&&%%%%%%%%%%##%&&&&&&&&&&&&&&&&*...,%%%%%%%%%%###(((/**,...............................
%%%%%%%%%%%%&&&&%&&&&&%%%%&&&&&&&&&&%%&%%%%%%%&&&&&&&&&&&&&&&&&&&%(/,%%%%%%%%%###((////*,,..............................
%%%%%%%%%%%%&&&&&&&&&&&&&&%%%%%&&&%%%%&%&%%%%%&&&&&&&&&&&&&&&&&&&&#%*%%%%%%%%######((((//**,*.,....,,**,..............,*
%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&%%%%%%%%&&%%%&&&&&&&&&&&&&&&&&&&&/##,,#%%%%%%%%######(((((////////////,*,,//////((((((((
%%%%%%%%%%%%%%%%%%%%%%&&&%%%&&&%&%%%%#######&&&&&&&&&&&&&&&&&&&%##%%#*#%%%%%%%%%%%#######((((((((((((((*/(((((((((######
%%%%%%%%%%%%%%%%%%%%%%&&&%%&&&&&&%%%%#####%%&&&&&&&&&&&&&&&&&&&%(/%%%%%%%%%##%%%%%%%#######((((((#########(/############
%%%%%%%%%%%%%%#%%%%%%%%%&%%%&&&&&&&&%%%%%%%%&&&&&&&&&&&&&&&&&#&&,/##%%%%%%%%%%%%%%%%%%%%##################%%%#/%%%%#####
%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%&&&&&&&&&%%%%&&&&&&&&&&&%#,%&(&&%&//*(%%%%%%%%%%%%%%%%%%%%%%%#%######%%%%%%%%%%%%%%#%%%%%#
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%%%%%%%%&&&&&&&&&&&&&&((*#(&&&%//(&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&%&&&&#(#/%#%((%&&&&%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&%%%%##//%#%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%#%##%%%%%#%%%####%#(########%#####%##%#(%&%&&&&&&&&&&&%%%%%%*%,,(#%%%%%%%%&&&&&#%%%%%%(%%%%%%%%%%%%%%&&&%%%%&&&&&&&%%%%
####################(#(###((((#(((((((((((%%%%%%%%%%&&%%%%%%%%##%%%**(/%%&&&&&&&%%%%%#%%%%%%%%%%%%%%&&&&&&&&&&&&&&&%%%%%
###########(#############((((((((((((((((#%%%%%#########%%%%%%%%*%%%%%%&&&&&&&%/(((((###%%&%%%%%%&%%%&&&&&&&&&&&&&%%%%%%
#%#%%%%#####%#%%%%%%##%%%#%######(#######%%%%%%%########%%%%%%%%%%%(%%%%&&&&&&/((((((##%&&&&&&&&&&&&&&&&&&&&&&&%%%&&&&%%
%%%%%%%#%%#######(#######((######/(#((((%%%%%%%%######%%%%%/((%%%%%%%%%%%##((/(((((((%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%";
        string _96 = @"
//////////////**///////******,,,,,,**,///*****//**,****,,,,,,*************************************//////////////////////
*****/**/**////********,,***************,,,,,,,,,,,,,,,,,,,,,,,,***********************************************/////////
*************/******///**********************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***,,**********************
*******************,,,,,,,**************,,,,,*,,,,,*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***************
%%*,*,,*,,,**,,,,,,,,,,,,,,,..,***..,*,********,,.....,,***,.,.,.,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********
%%%%%%%%%%%/,,..,.,..,,,,,..,,....,,,,,,......,....,,..,,......,,,,,,,...................,,,,...,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%/,,,,,,,,.................................................................................,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%&.....................................................,*//,................................,,,,,,,,
%%%%%%%%%%%%%%%%%&%%%%%%%&&%%%........................................*(&&&&%%%%%%##....................................
%%%%%%%%%%%%%%%%%&&&&&&&&&&%%&&&%%%%................(&%%*...........*#%%%%%%%%%%%###(/..................................
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&%%%%%%%(####(((%&&&&&&&&&&&%....../%%%%%%%%%%%###((/**................................
%%%%%%%%%%%%%%&%%%%%%%%&&&&&&&&&&&&%%%%%%%%%%%##&&&&&&&&&&&&&&&&%.../%%%%%%%%%%###(((/**,...............................
%%%%%%%%%%%%&&&&%&&&&&%%%%&&&&&&&&&&%%&%%%%%%%%&&&&&&&&&&&&&&&&&&&#/(%%%%%%%%%###((////*,*..............................
%%%%%%%%%%%%&&&&&&&&&&&&&&%&%%%%&&%%%%&%&&%%%%&&&&&&&&&&&&&&&&&&&&%*(%%%%%%%%######((((//****.,.....,****,,........,*/((
%%%%%%%%%%%%%%%%%%%%%%%%&&%&&&&&&%%%%%%%&&%(#&&&&&&&&&&&&&&&&&&&&%#(*,#%%%%%%%%#######((((///////////*,,.,/////(((((((((
%%%%%%%%%%%%%%%%%%%%%%&&&&%&&&&%%%%%########&&&&&&&&&&&&&&&&&&&%%%%##/%%%%%%%%%%%%#######((((((((((((((*/(((((((((######
%%%%%%%%%%%%%%%%%%%%%%&&&%%&&&&&&%%%#%#####%%&&&&&&&&&&&&&&&&&&&%#%%%%%%%%(#%%%%%%%%#########((((#########(#############
%%%%%%%%%%%%%%#%%%%%%%%%&%%%&&&&&&&&%%&%%%%%&&&&&&&&&&&&&&&%&&&&%**((%%%%#%%%%%%%%%%%%%%##################%%%##%%%%%%%##
%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%&&&&&&&&%%%%%&&&&&&&&&&&&%(%%,*&&&%#*/(%%%%%%%%%%%%%%%%%%%%%%%%######%%%%%%%%%%%%%(%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%%%%%%%%&&&&&&&&&&&&&%(//%(*(&%%%%&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%&&&&&&&&&&&&&&&&%##(//*##%%&&%&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(%%
%%#%%%%%%%%%%%%%%##%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&%%%%*%(,*(%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#&
%%%#%##%%%#%%################%#####%##%(((&%%&&&&&&&&&&%%%%%#*%/**(%%%%%%%%&&&%%%%%%%%#%%%%%%%%%%%%%%%&&&%%%%&&&&&&&%%%%
#######(#############((###((((((((((((((((#%%%%%%%%%&&&%%%%%%%*#%%%%#.%%&&&&&&&##%%%%#%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&%%%%
##########(((############((((((((((((((#(#%%%%%########%%%%%%%%%.%%%%%%%&&&&&&/((((((##%%%%&&%%%&&%%&&&&&&&&&&&&&&%%%%%%
##%%%%########%%%%%%#%%#########(########%%%%%%%########%%%%%%%%%%%%%%%%%&&&&/((((((##%%&&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%
%%%%%%%%%#################(#####(#//#(((%%%%%%%%########%%%%((%%%%%%%%%%%((/(/(((((//#&&&&&&&&&&&%&&&&&&&&&&&&&&&&&&&&%%";
        string _97 = @"
//////////////**///////******,,,,,,**,///*****//**,****,,,,,,*************************************//////////////////////
*****/**/***///********,,***************,,,,,,,,,,,,,,,,,,,,,,,,***********************************************/////////
*************/******///**********************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***,,**********************
*******************,,,,,,,**************,,,,,*,,,,,*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***************
%%*,*,,*,,,**,,,,,,,,,,,,,,,..,***..,*,********,,.....,,***,.,.,.,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********
%%%%%%%%%%%/,,..,.,..,,,,,..,,....,,,,,,......,....,,..,,......,,,,,,,...................,,,,...,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%/,,,,,,,,.................................................................................,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%&.....................................................,*//,................................,,,,,,,,
%%%%%%%%%%%%%%%%%&%%%%%%%&&%%%........................................*(&&&&%%%%%%##....................................
%%%%%%%%%%%%%%%%%&&&&&&&&&&%%&&&%%%%................(&%%*...........*#%%%%%%%%%%%###(/..................................
%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&%%%%%%%(####(((%&&&&&&&&&&&%....../%%%%%%%%%%%###((/**................................
%%%%%%%%%%%%%%&%%%%%%%%&&&&&&&&&&&&%%%%%%%%%%%##&&&&&&&&&&&&&&&&%.../%%%%%%%%%%###(((/**,...............................
%%%%%%%%%%%%&&&&%&&&&&%%%%&&&&&&&&&&%%&%%%%%%%%&&&&&&&&&&&&&&&&&&&#/(%%%%%%%%%###((////*,*..............................
%%%%%%%%%%%%&&&&&&&&&&&&&&%&%%%%&&%%%%&%&&%%%%&&&&&&&&&&&&&&&&&&&&%*(%%%%%%%%######((((//****.,.....,****,,........,*/((
%%%%%%%%%%%%%%%%%%%%%%%%&&%&&&&&&%%%%%%%&&%(#&&&&&&&&&&&&&&&&&&&&%#(*,#%%%%%%%%#######((((///////////*,,.,/////(((((((((
%%%%%%%%%%%%%%%%%%%%%%&&&&%&&&&%%%%%########&&&&&&&&&&&&&&&&&&&%%%%##/%%%%%%%%%%%%#######((((((((((((((*/(((((((((######
%%%%%%%%%%%%%%%%%%%%%%&&&%%&&&&&&%%%#%#####%%&&&&&&&&&&&&&&&&&&&%#%%%%%%%%(#%%%%%%%%#########((((#########(#############
%%%%%%%%%%%%%%#%%%%%%%%%&%%%&&&&&&&&%%&%%%%%&&&&&&&&&&&&&&&%&&&&%**((%%%%#%%%%%%%%%%%%%%##################%%%##%%%%%%%##
%%%%%%%%%%%%%%%%%%%%%&&&&&&%%%&&&&&&&&%%%%%&&&&&&&&&&&&%(%%,*&&&%#*/(%%%%%%%%%%%%%%%%%%%%%%%%######%%%%%%%%%%%%%(%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%%%%%%%%%%%%&&&&&&&&&&&&&%(//%(*(&%%%%&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%&&&&&&&&&&&&&&&&%##(//*##%%&&%&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(%%
%%#%%%%%%%%%%%%%%##%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&%%%%*%(,*(%%%%%%%#%%%&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#&
%%%#%##%%%#%%################%#####%##%(((&%%&&&&&&&&&&%%%%%#*%/**(%%%%%%%%&&&%%%%%%%%#%%%%%%%%%%%%%%%&&&%%%%&&&&&&&%%%%
#######(#############((###((((((((((((((((#%%%%%%%%%&&&%%%%%%%*#%%%%#.%%&&&&&&&##%%%%#%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&%%%%
##########(((############((((((((((((((#(#%%%%%########%%%%%%%%%.%%%%%%%&&&&&&/((((((##%%%%%%%%%&&%%&&&&&&&&&&&&&&%%%%%%
##%%%%########%%%%%%#%%#########(########%%%%%%%########%%%%%%%%%%%%%%%%%&&&&/((((((##%%&&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%
%%%%%%%%%#################(#####(#//#(((%%%%%%%%########%%%%((%%%%%%%%%%%((/(/(((((//#&&&&&&&&&&&%&&&&&&&&&&&&&&&&&&&&%%";
        string _98 = @"
//////////////***//////******,,,,,,**,///*,***//**,****,,,,,,*************************************//////////////////////
*****/**/***///********,,***************,,,,,,,,,,,,,,,,,,,,,,,,************************************************////////
*************/******///*********************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***,,**********************
*******************,,,,,,,,*************,,,,,*,,,,,*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***************
%%/,*,,*,,,**,,,,,,,,,,,,,,...,***..**,,******,.,.....,,***,.,.,.,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********
%%%%%%%%%%#*,,..,.,..,,,,,.,,,....,,,,,,...........,,..,,......,,,,,,,..........................,,,,,,,,,,,,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%.,,,,,,,,.................................................................................,,,,,,,,,,,,,
%%%%%%%%%%%%%%%%%%%%%/..................................................,**/#%%(,...............................,,..,,,,
%%%%%%%%%%%%%%%%%&%%%%%%%&&%%/......................................./%&&&&%%%%%%%#(....................................
%%%%%%%%%%%%%%%%%&&&&&&&&&&%%&&&%%%,................,,,,...........*%%&%%%%%%%%%%##((*..................................
%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&%%%%%%%####(((((%&&&&&&&&&&/.....*%%%%%%%%%%%%###((/*.................................
%%%%%%%%%%%%%%&%%%%%%%%&&&&&&&&&&&&%%%%%%%%%%%#(%&&&&&&&&&&&&&&&#..*%%%%%%%%%%%###(((/*,................................
%%%%%%%%%%%%&&&&%&&&%%%%%%&&&&&&&&&&%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&(#%%%%%%%%%%###((////*,,..............................
%%%%%%%%%%%%&&&&&&&&&&&&&&&%%%&&&&%%%%&%&&%%%%&&&&&&&&&&&&&&&&&&&&&(%%%%%%%%%######((((/***,......,,,**,.............,,*
%%%%%%%%%%%%%%%%%%%%%%&&&&%&&&&%%%%%%%%%%&%%%&&&&&&&&&&&&&&&&&&&&&(**#%%%%%%%%%######(((((//////////*,*.*////////(((((((
%%%%%%%%%%%%%%%%%%%%%%&&&%&%&&&%&%%%########&&&&&&&&&&&&&&&&&&&%%%%((#%%%%%%%%%%%#######(((((((((((((/*/(((((((((((#####
%%%%%%%%%%%%%%%%%%%%%%&&&%%&&&&&&%%#%######%&&&&&&&&&&&&&&&&&&%%%&%%%%%%%(#%%%%%%%%%#######((((((((#####(*(#############
%%%%%%%%%%%%%%##%%%%%%%%%%%&&&&&&&&&%%%%%%%%&&&&&&&&&&&&&&&&&&&&&#*(#%%%%%%%%%%%%%%%%%%%####################(##%%%%#####
%%%%%%%%%%%%%%%%%%%%%&&&&&%%%&&&&&&&&&%%%%%&&&&&&&&&&&&&%&&/,,&&&&%%%%%#%%%%%%%%%%%%%%%%%%%#######%%%%%%%%%%%%(##%%%%%%#
%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%%%%%%%%%%%%%&&&&&&&&&&&&&#(/(%***%&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%(%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##%%&&&&&&&&&&&&&&%##//%/,/(#&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&%%%(#/(/*/%%&&&%%%%%&%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%&
#%%#%%%%%%%%%%#########%####%#####%%%###%#&&&&&&&&&&&&%%%%%#(*/,,/%%%%#%%%&&&&%%%%%%##%%%%%%%%%%%%%%%%%%%%%%%&&&&&%%%%%%
#####################(####((((((((((((((((%%%%%&&&&&&&%%%%%%%*#%%%%%%#%&&&&&&&#%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&%%%%%%
##########(#####(#####(((((((((((((#((((((%%%%%####%%%%%%%%%%%*%%%%%%%%&&&&&&/((((((((%%%%%%%%%%%%&&&&&&&&&&&&&&%%%%%%%%
#%%%%%#######%%%%%%#%%%%########((########%%%%%########%%%%%%%%%#%%%%%%%&&&&/(((((((#(%&&&&&&&&&&%&&&&&&&&&&&&&%%%%%%%%%
%%%%%%%%##################(((####(##((/(#%%%%%%%%#######%%%%%%%%%%%%%#%%%%#((((((((/%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%";
         Console.BackgroundColor = ConsoleColor.White;
         Console.ForegroundColor = ConsoleColor.Black;
         Console.WindowWidth = 120;
         Console.WindowHeight = 28;

         string[] butterfly_frames = new string[] { _1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51, _52, _53, _54, _55, _56, _57, _58, _59, _60, _61, _62, _63, _64, _65, _66, _67, _68, _69, _70, _71, _72, _73, _74, _75, _76, _77, _78, _79, _80, _81, _82, _83, _84, _85, _86, _87, _88, _89, _90, _91, _92, _93, _94, _95, _96, _97,_98};
         for (int i = 0; i < repeats; i++)
         {

             foreach (string butterfly_frame in butterfly_frames)
             {

                 Console.WriteLine(butterfly_frame);
                 Thread.Sleep(speed);


             }
         }
    }
    static void Cow_animation(int speed = 100, int repeats = 1)
    {

        string _0 = @"
*********************************************************************************************///////////////////////////
********************************,**************************************************************/////////////////////////
****************,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******,************************************************///////////////
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***************************************/////////////
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,**************************************/////////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************///////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%%/(,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************//
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&&&&&%&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,/%%%%%%%,,*,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,&,,,,,,,,&&&&&&%%,,,,*****,*//*************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&&(,,,,&&&%,,,&&@@@@@&&&%,*&&%*&&&&&&&&,*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.&&&&&&&&&#&&&&&&&&@@@@@@@@@@@@@@@@&*,&&(*,&@@@@@@@@@@***&&&&&&&&**,&&%********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,&(/&&&&&%%%&%%%%&&&&&&&@@@@@@@@@@@@@@///*/**&@@@@@@@@@/////@&&&&@***,**@&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/##,,,,,,,,,,,,,.(&%%%%%@@@@@@@@@@@#((@@(//#@@@@@@@@&(((((&&&&&*,,,,,,,&#******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*%##&@@@@@@@@@@@##@@((&@@@@@@@@#####&@&&,,,,,,,,**,#******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/%#&&((@@@@@@&##@@&#@@@@&#%&###&@@@&,,,,,,,,,,,,,#******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((###%&&&&@@&%%%&@@@@%%%&%%%@&(/****,,,,,,,,,,#(,****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((###(/,,,,,,,,*****,,,,&&%&&&&%#(///*,,,,,,,,(#/,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((((#%#,,,,,,,,,,,,,,,,,,,,%&%#,*&*#((/,,,,,,,,*#(****************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(###,*&%%(,,,,,,,,,,,,,,,,,(##,,,,,,#(*,,,,,,,,,%#****************
********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((,,,,,/##(,,,,,,,,,,,,,,,((,,,,,,,/(*,,,,,**********************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*//*******/#(%#***********/((/////////#((/////////*****************
************************,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(%/,,,,,,,,,,%(***********/(#//////////%(%%#////////*****//********
********************************,***,,,,,,,,,,,,,,/#%%(/***,,,,,,,,,,,,,,,,,,,(%&&/***********/%/*****************//////
/////*************************************************,,,,,,,,,,,,,,,,,,,,,,,,,******************************///////////
&&&&&&&&&&&&&&&@@@@@&&&%%#####(////////****************************************************************/////////////////";
        string _1 = @"
***********************************************************************************************/////////////////////////
********************************,************************************************************///////////////////////////
****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************************/////////////
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****************************************/////////////
****,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,**************************************/////////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***************************************//////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/&##/,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************//
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/&&&&&&%&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,(%%%%%%%,,*,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,&,,,,,,,*&&&&&&%%,,,,*****,*//*************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/&&&&&&&%&&&&&&&&&&&&&&&&&&&&&/,,,,&&&#,,,&&&&@@@&&&%,*&&%*&&&&&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&#&&&&&&&&@@@@@@@@@@@@@@@@&*,&&(*,&@@@@@@@@@@***&&&&&&&&**,&&(********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,&(/&&&&%%%&&%%%%&&&&&&&@@@@@@@@@@@@@@///****&@@@@@@@@@/////@&&&&&,**,**&#*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**.,,,,,,,,,,,,.(&%%%%%@@@@@@@@@@@#((@@(//#@@@@@@@@#(((((&&&&&*,,,,,,,&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*%##&@@@@@@@@@@&##@@((&@@@@@@@&#####&@&&,,,,,,,,***(******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(%##&#(@@@@@@&##@@&#@@@@%#%%###@@@&#,,,,,,,,,,,,,(******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#(((##%&&&&@@&%%%&@@@@%%%&%%&&#(/***,,,,,,,,,,,#/*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((((##*/,,,,,,.,**///,,,,&&&&&&&%#(///,,,,,,,,,#(/****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((((#*,,,,,,,,,,,,,,,,,,,,/&%%**&/#((,,,,,,**,*#(****************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,###*&%%(,,,,,,,,,,,,,,,,,,,##*,,,,*((,,,,,,****%#****************
********,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(#,,,*###(.,,,,,,,,,,,,,,,/(*,,,,,*(/,***,,**********************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/(*****/####**********//*/((///////#((//////////*****************
*********************,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/#%*,,,,,,,,*/*************/((/////////#%%%/////////*****//******//
******************************,,,,,,,,,,,,,,,,,,,,,/#%%/***,,,,,,,,,,,,,,,,,,,*%%%%/*********///******************//////
/////*********************************************************,,,,,,,,,,,,,,,*,********************************/////////
&&&&&&&&&&&&&&@@@@@&&&%%%###((((////*******************************************************************/////////////////";
        string _10 = @"
*******************************************************************************************/////////////////////////////
********************************,************************************************************///////////////////////////
****************,*****,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************************/////////////////////
**********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,,,,*,*****************************************//////////////
****,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///////////
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************//////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************//
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&&&&&%&&&&&&&&&&&&&&&%,,,,,,,,,,,,,,,%%%%%%&*,,,,***********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,(&&&%%%%*,,,***********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&#,,,,#&&&,,,,&&&&&&&&&&%,,*#,**,/%&&&***********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.&&&&&&&&&(&&&&&&@@@@@@@@@@@@@@@@&&/,&&&&,,&&@@@@@@@@&(**&&&&&&&&**&&#*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,%((%&&&%%%&%%%%&&&@@@@@@@@@@@@@@@@@@&*******@@@@@@@@@@/////&&&&&&,**,*&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,&%%%%%%%@@@@@@@@@@@@@((&@%//(@@@@@@@&(((((%@&&&&,,,,,,*&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(&###@@@@@@@@@@@%(@@%((&@@@@&@#####&@@&&&,,,,,,,,*%****,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(%%#%%%#@@#@@@@@##@@&(@@@@&%%%@@@@@%%%,,,,,,,,,,,//*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(#%%%&&%%#####%&&@&%%%#@@@@@%%&%##(/**%%,,,,,,,,,,,,/,,,,,,*************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(##%#,,,,###((#&&&&&@@&&&&@@&*(&%%&#(/*(,,,,,,,,,,,,//******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(##(,,,,,,,(((((,,,,,,,,,,,,,,,,,,,*%(((#*,,,,,,,,,***%(/,***************
****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((/,,,,,,,####,,,,,,,,,,,,,,,,,,,,,*(#&#,,,,,,,,,,**,*(#(***************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(/,,,,,,,,(((,,,,,,,,,,,,,,,,,,,,*///&/,,,,,,,,,***********************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(##,,,,,,,,*//********************/(/(%/,,,,,,,*************************
****************,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,**#(#,,,,,,,(##/****************////(/%%%///////////////////***//********
***************************,,,,,,,,,,,,,,,,,,,,*,,****,,,/(##*,,***,,,,,,,,,,,,**(%(#%%%////****************/*********//
///***********************************************,*,*,,,,,,,,,,,,,,,,,,,,,,,,,*,*******************************////////
(//////****************************************************************************************************/////////////";
        string _11 = @"
*******************************************************************************************/////////////////////////////
*********************************************************************************************///////////////////////////
****************,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************************/////////////////////
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****,*,*****************************************//////////////
****,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///////////
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************//////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#%//,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************//
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&&&&&&%&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,%%%%%%&/,,,,***********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&&&&&&&&&&&&&&&&&&&/,,,,,,,,,,,,,/&&&%%%%(,,,***********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,(&&&,,,,&&&&&&&&&&&,,*%,****#&&&***********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.&&&&&&&&&(&&&&&&@@@@@@@@@@@@@@@@&&#,&&&&,,&&@@@@@@@@&#**%&&&&&&&**&&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,##((&&&%%%&%%%%%&&@@@@@@@@@@@@@@@@@@@/******@@@@@@@@@@/////&&&&&&,,*,,&(********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,%%%%%%%%@@@@@@@@@@@@@((&@%///@@@@@@@&(((((&&&&&&,,,,,*,&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&###@@@@@@@@@@@%(@@&((%@@@@&%####&@@@@&@,,,,,,,,,#/***,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(%&#%%%(@@#&@@@@%#&@@(&@@@@%%@@@@&&#%%,,,,,,,,,,,*/*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(%%%%&&%%#####%&&@@%%%%@@@@@%%&%#((**#%%,,,,,,,,,,,,/,,,,,,*************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(##%%%/,,,/##((#&@&&&&@&&&&&@&,*&&%%(/*/&,,,,,,,,,,,,//******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,####,,,,,,,,((((#,,,,,,,,,,,,,,,,,,,*#((#&#,,,,,,,,,,,,#(/,***************
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((,,,,,,,,*###*,,,,,,,,,,,,,,,,,,,*(((&%*,,,,,,,,***,*%#(***************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(/,,,,,,,,,*((,,,,,,,,,,,,,,,,,,,,//,,#%*,,,,,,,,***********************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(#(,,,,,,,,,,///****************//(//**#(***,,,,*,***********************
****************,**,,,,,,,,,,,,,,,,,,,,,,,,,,**(((*,,,,,,**/##%/**************/*//////(%(//////////////////****/********
***************************,,,,,,,,,,,,,,,,,,*,/****,,,,,,/(##*,****,,,,,,,,,**##((**(%%#//*****************/*********//
///*************************************************,*,,,,,,,,,,,,,,,,,,,,,,,,,*,*******************************////////
####(((///*************************************************************************************************/////////////";
        string _12 = @"
*******************************************************************************************/////////////////////////////
********************************,************************************************************///////////////////////////
****************,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************************/////////////////////
***********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,,,,*,*****************************************//////////////
****,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///////////
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************************************////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%%/(,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************//
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&&&&&&%&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,%%%%%%&/,,,,***********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&&&&&&&&&&&&&&&&&&&(,,,,,,,,,,,,,/&&&%%%%(,,,***********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,/&&&,,,,&&&&&&&&&&&,,*%,**,*#&&&/**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.&&&&&&&&&(&&&&&&@@@@@@@@@@@@@@@@&&#,&&&&,,&&@@@@@@@@&#**%&&&&&&&**&&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,##((&&&%%%&%%%%%&&@@@@@@@@@@@@@@@@@@@/******@@@@@@@@@@/////&&&&&&,,*,,&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,..,,,,,,,,,,,.%%%%%%%%@@@@@@@@@@@@@((@@%///@@@@@@@##((((&&&&&&,,,,,**&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&###@@@@@@@@@@@&(@@&((&@@@@&####%@@@@@&@,,,,,,,,,/(***,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/#&##%%#@@(#@@@@##&@&(@@@@@%%@@@@&&%%%,,,,,,,,,,,,/,******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/#%%%&&%%#####%%&@@%%%#@@@@@%%&%#(/*(&%%,,,,,,,,,,,,(,,,,,,*************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/(##%%%&%*,*##((#&@%&&&@&&&&&@%,*&&%(/*/@&/,,,,,,,,,,,(/,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(##(,,,,,,,,((((#,,,,,,,,,,,,,,,,,,*(((#&&#*,,,,,,,,,,*#/*,***************
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((*,,,,,,,,,%##(,,,,,,,,,,,,,,,,,,/((,,&&#,,,,,,,,*****#(****************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#(,,,,,,,,,,,/((,,,,,,,,,,,,,,,,,///,,,*&(,,,,,,,,******/****************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/##,,,,,,,,,,,///***************/((/*****((*,,,,**************************
****************,**,,,,,,,,,,,,,,,,,,,,,,,,,,((#(,,,,,,,,,**(###/***********/*//(//////%%//////////////////****/********
***************************,,,,,,,,,,,,,,,,**#//***,,,,,,,**/#%*,***,,,,,,,*/##((****/%%%///***************//*********//
///*************************************************,*,*,,,,,,,,,,,,,,,,,,,,,,,*,******************************/*///////
(((////****************************************************************************************************/////////////";
        string _13 = @"
*****************************************************************************************///////////////////////////////
********************************,************************************************************///////////////////////////
****************,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************************/////////////////////
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,,,,*,*****************************************//////////////
****,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///////////
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************//////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%%/(,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************//
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&&&&&&%&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,%%%%%%&/,,,,***********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&&&&&&&&&&&&&&&&&&&(,,,,,,,,,,,,,/&&&%%%%(,,,***********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,/&&&,,,,&&&&&&&&&&&,,*%,**,*#&&&/**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.&&&&&&&&&(&&&&&&@@@@@@@@@@@@@@@@&&#,&&&&,,&&@@@@@@@@&#**%&&&&&&&**&&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,##((&&&%%%&%%%%%&&@@@@@@@@@@@@@@@@@@@/******@@@@@@@@@@/////&&&&&&,,*,,&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,..,,,,,,,,,,,.%%%%%%%%@@@@@@@@@@@@@((@@%///@@@@@@@##((((&&&&&&,,,,,**&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&###@@@@@@@@@@@&(@@&((&@@@@&####%@@@@@&@,,,,,,,,,/(***,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/#&##%%#@@(#@@@@##&@&(@@@@@%%@@@@&&%%%,,,,,,,,,,,,/,******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/#%%%&&%%#####%%&@@%%%#@@@@@%%&%#(/*(&%%,,,,,,,,,,,,(,,,,,,*************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/(##%%%&%*,*##((#&@%&&&@&&&&&@%,*&&%(/*/@&/,,,,,,,,,,,(/,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(##(,,,,,,,,((((#,,,,,,,,,,,,,,,,,,*(((#&&#*,,,,,,,,,,*#/*,***************
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((*,,,,,,,,,%##(,,,,,,,,,,,,,,,,,,/((,,&&#,,,,,,,,*****#(****************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#(,,,,,,,,,,,/((,,,,,,,,,,,,,,,,,//(,,,*&(,,,,,,,,******/****************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/##,,,,,,,,,,,///***************/((/*****((*,,,,**************************
****************,**,,,,,,,,,,,,,,,,,,,,,,,,,,((#(,,,,,,,,,**(###/***********/*//(//////%%//////////////////****/********
***************************,,,,,,,,,,,,,,,,**#//***,,,,,,,**/#%*,***,,,,,,,*/##((****/%%%///***************//*********//
///*************************************************,*,*,,,,,,,,,,,,,,,,,,,,,,,*,******************************/*///////
(((////****************************************************************************************************/////////////";
        string _14 = @"
*****************************************************************************************///////////////////////////////
********************************,************************************************************///////////////////////////
****************,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************************/////////////////////
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,*****************************************//////////////
****,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///////////
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************//////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************//
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(&&&&&&%%&&&&&&&&&&&&&&,,,,,,,,,,,,,,,%%%%%%&/,,,,***********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&(,,,,,,,,,,,,,/&&&%%%%#,,,***********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,/&&&,,,,&&&&&&&&&&&,,,%,**,*(&&&(**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&(&&&&&&@@@@@@@@@@@@@@@@&&%*&&&&*,&&@@@@@@@@&%**#&&&&&&&**@&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,%(/#&&&&%%%%%%%%&&@@@@@@@@@@@@@@@@@@@/******@@@@@@@@@@/////&&&&&&,,*,*&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/.,,,,,,,,,,.%%%%%%%%@@@@@@@@@@@@@((&@%///@@@@@@@##((((&&&&&&,,,,,**&%*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&###@@@@@@@@@@@&(@@&((&@@@@%###%&@@@@@&&,,,,,,,,,*(***,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&##%%#@@%(@@@@%#&@@(@@@@@%%@@@@&&%%%*,,,,,,,,,,,(*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(#%%&%%&##(#%%&&@%%%#@@@@@%%%#((//&&%%,,,,,,,,,,,,(*,,,,,*************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(#%%%%&&(*###(#&@%&&&@&&&&&@&,*&%(/*/@@&#,,,,,,,,,,,#/,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((##/,,,,,,*((((,,,,,,,,,,,,,,,,,*((/(%&&%(,,,,,,,,,,/(/*,***************
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(##*,,,,,,,,(###,,,,,,,,,,,,,,,,,((#,,,#&%*,,,,,,,****%(/****************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((*,,,,,,,,,,,((/,,,,,,,,,,,,,,,/(*,,,,,((*,,,,,,,*****/*****************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((,,,,,,,,,,,,///*************/(/******,/(/,,,,**************************
****************,**,,,,,,,,,,,,,,,,,,,,,,,,,,*(#@,,,,,,,,,,,*/(#%/**********//(////////(%%/////////////////****//*******
***************************,,,,,,,,,,,,,,,,(#%&&***,,,,,,,,,*(##*,***,,,,**%%#(*,,***/#%%%///**************//*********//
///***********************************************,*,*,,,,,,,,,,,,,,,,,,,,,,,,,**********************************///////
/////******************************************************************************************************/////////////";
        string _15 = @"
*****************************************************************************************///////////////////////////////
********************************,************************************************************///////////////////////////
****************,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************************/**//////////////////
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,*****************************************//////////////
****,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///////////
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************//////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(&&&&&&%%&&&&&&&&&&&&&&,,,,,,,,,,,,,,,%%%%%%&/,,,,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&&&&&&&&&&&&&&&&&&&(,,,,,,,,,,,,,/&&&%%%%#,,,***********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,/&&&,,,,&&&&&&&&&&&,,,%,**,*(&&&(**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&(&&&&&@@@@@@@@@@@@@@@@@&&%*&&&&*,&&@@@@@@@@&%**#&&&&&&&*,@&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,%(/#&&&&%%%%%%%%&&@@@@@@@@@@@@@@@@@@@/******@@@@@@@@@@/////&&&&&&,,*,*&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**.,,,,,,,,,,.%%%%%%%%@@@@@@@@@@@@@((&@%///@@@@@@@##((((&&&&&&,,,,,,*&%*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&###@@@@@@@@@@@&(@@@((&@@@@%###%&@@@@@&&,,,,,,,,,*(***,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&#%%%#@@%(@@@@%#&@@(@@@@@%%@@@@&&%%%*,,,,,,,,,,,(*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(#%%&%%&##(#%%&&@%%%#@@@@@%%%#((//&&%%,,,,,,,,,,,,(*,,,,,*************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(#%%%%&&(*###(#&@%&&&@&&&&&@&,*&%(/*/@@&#,,,,,,,,,,,#/,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((##/,,,,,,*((((,,,,,,,,,,,,,,,,,*((/(%&&%(,,,,,,,,,,/(/*,***************
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(##*,,,,,,,,(###,,,,,,,,,,,,,,,,,((#,,,#&%*,,,,,,,****%(/****************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((*,,,,,,,,,,,((/,,,,,,,,,,,,,,,/(*,,,,,((*,,,,,,,*****/*****************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((,,,,,,,,,,,,///*************/(/******,/(/,,,,**************************
****************,**,,,,,,,,,,,,,,,,,,,,,,,,,,/(#@,,,,,,,,,,,*/(#%/**********//(////////#%%/////////////////****//*******
***************************,,,,,,,,,,,,,,,,(#%&&**,,,,,,,,,,*(##*,***,,,,**%%#(*,,,**/#%%%///**************//*********//
///***********************************************,***,,,,,,,,,,,,,,,,,,,,,,,,,**********************************///////
/////******************************************************************************************************/////////////";
        string _16 = @"
*****************************************************************************************///////////////////////////////
*********************************************************************************************///////////////////////////
****************,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************************/***/////////////////
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************************//////////////
****,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///////////
,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************//////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&#,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(&&&&&%&%&&&&&&&&&&&&&&,,,,,,,,,,,,,,,%%%%%%&(,,,,***********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&%,,,,,,,,,,,,,*&&&&%%%#,,,,**********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,&&&,,,,%&&&&&&&&&&,,,%,**,*(&&&%**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&(%&&&&&@@@@@@@@@@@@@@@@&&&*%&&&,,&&@@@@@@@@&%**#&&&&&&&**#&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,&#/%&&&&%%%%%%%%&&&@@@@@@@@@@@@@@@@@@(******@@@@@@@@@@/////&&&&&&*,,,*/&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*%%,,,,,,,,,,,.#&%%%%%%@@@@@@@@@@@@@((&@&///@@@@@@@%#((((%&@&&&*,,,,,**&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%##@@@@@@@@@@@@(&@@((%@@@@&####%&@@@@&&,,,,,,,,**#***,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&#%%%#%@@#@@@@%#&@@(@@@@@%%@@@@@@&%%(,,,,,,,,,,,(/******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(#%%&%%&#####%&&@%%%#@@@@@%&%#(//(&&%%,,,,,,,,,,,,(/,,,,,*************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(#%%%&&%,(###(#&#%&@&&&&&&@%,,&#(//&@@&#,,,,,,,,,,,#/,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,//((##,,,,,,/((((,,,,,,,,,,,,,,,,#(///*&&%(*,,,,,,,,,#(/*,***************
,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,//##,,,,,,,,,(###,,,,,,,,,,,,,,,*((#,,,,&&#*,,,,,,***/#(*****************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((,,,,,,,,,,,*((/,,,,,,,,,,,,,*/#,,,,,,,#(*,,,,,,******/****************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/((,,,,,,,,,,,*///********,**//(********,/(**,,,*************************
*******************,,,,,,,,,,,,,,,,,,,,,,,,,,*/(@,,,,,,,,,,,,**(#%/********//%*/////////#%%////////////////*****/*******
***************************,,,,,,,,,,,,,,,,*#%%%/**,,,,,,,,,,/((#*,***,,,%#%%*,,,,,**//(#%%///************//**********//
///****************************************************,,,,,,,,,,,,,,,,,,,,,,,,**********************************///////
////*******************************************************************************************************/////////////";
        string _17 = @"
**************************************************************************************/*////////////////////////////////
********************************,***********************************************************////////////////////////////
****************,*,**,,,,,,,,,,,,,,,,,,,,,,,,,,*,******************************************************/////////////////
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,****************************************///////////////
****,***,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///////////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************//////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************///
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&#*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/&&&&&%&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,#%%%%%%%,,,,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,&&&&&%%%,,,,*******/**************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,&&&,,,,&&&&&&&&&&&,,,%****(#&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&&&&&&&&(%&&&&&@@@@@@@@@@@@@@@@@&&*(&&&,,%&@@@@@@@@@%**(&&&&&&&***&&%********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,##/%&&&&%%%%%%%%&&&@@@@@@@@@@@@@@@@@@%/*****@@@@@@@@@@/////&&&&&&(,*,**&&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(%&#,,,,,,,,,,,/&%%%%%%&@@@@@@@@@@@@((&@&///@@@@@@@&#((((#&@&&&(,,*,***&/******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%##@@@@@@@@@@@@(%@@/(%@@@@%#####%&@@@@&/,,,,,,,***(******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%%%%#(@@#&@@@%#%@@(@@@@@%%@@@@@@@%%#,,,,,,,,,,,*/******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(#%&%%%&####%&&@%%%%&@@@@%%%#((/(&&%%/,,,,,,,,,,,*/,,,,**************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/#%%%%&,*###((%*/%&@&&&&&@(,,%#(//&&@&%(,,,,,,,,,,#/,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(((#,,,,,,(((((,,,,,,,,,,,,,,,#(//*,&&&((,,,,,,,,,#/,*****************
,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/##(,,,,,,,,(###,,,,,,,,,,,,,,(((#,,,,#&%/,,,,,,,**%((*****************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((,,,,,,,,,,,*/(/,,,,,,,,,,,,/(#,,,,,,,(#/,,,,*,******/****************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((,,,,,,,,,,,**////*********//(**********((*,,,*************************
****************,**,,,,,,,,,,,,,,,,,,,,,,,,,,,*(%/,,,,,,,,,,,,**(##/******/*#%///////////#%(///////////////*****/*******
***************************,,,,,,,,,,,,,,,,,(#%%%/*,,,,,,,,,,,(/(#*****,,/(#%,,,,,,*///*(#%%//************//**********//
///***********************************************,*,*,,,,,,,,,,,,,,,,,,,,,,,,,********************************/*///////
/////*****************************************************************************************************//////////////";
        string _18 = @"
****************************************************************************************////////////////////////////////
********************************************************************************************////////////////////////////
****************,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,****************************************************/*/////////////////
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,****************************************///////////////
****,***,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,************************************///////////
,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************//////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************///
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(%/*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&%%&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,/%%%%%%%,,,,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,&&&&&%%%,,,,*******/**************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&&&&&&&&&&&&&&&&&&&&&&&&&&&&*,,,,&&&*,,,%&&&&&&&&&&,,,&/***(%&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&##&&&&&@@@@@@@@@@@@@@@@@&&,*&&&*,(&@@@@@@@@@&**/&&&&&&&,*,&&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(/&&&&&&%%%%%%%&&&@@@@@@@@@@@@@@@@@@&/*****&@@@@@@@@@/////&&&&&&%*****&&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(&%&*,,,,,,,,,,*&%%%%%%%@@@@@@@@@@@@((%@@///@@@@@@@@#(((((&@&&&%,,*,***#&******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%%##&@@@@@@@@@@@##@@/(#@@@@&######&@@@@&%,,,,,,****(******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%%#%%##@@%#@@@%#%@@(@@@@@%%@@@@@@@&%#,,,,,,,,,,,*/******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(#&&%%&%#(##%&@&%%%&@@@@%%%#((/(%&%%#,,,,,,,,,,,,/,,,,**************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(#%%%%#,#%##((**#&@&&&&&@(,,%#(//&&@&%#,,,,,,,,,,(/,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((##,,,,,,(#(((,,,,,,,,,,,,,,#(//*,%&&#(*,,,,,,,,#/,*****************
,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/###,,,,,,,,(##(,,,,,,,,,,,,,((((*,,,,&%#*,,,,,***%(******************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((,,,,,,,,,,,,/((,,,,,,,,,,,*(#,,,,,,,,((*,,,*,****/******************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((,,,,,,,,,,****///**,,,,,**/(*******,,,/(/,,**************************
****************,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(&*,,,,,,,,,,,,**(##/******/(#///////////(%%////////////////****//******
***************************,,,,,,,,,,,,,,,,,,/#%%#***,,,,,,,,,,,*(##*,***,/#%*,,,,,,**///(#&(//***********(/**********//
///*******************************************,*,*,*,,,,,,,,,,,,,,,,,,,,,,,,,,,*,********************************///////
///////***************************************************************************************************//////////////";
        string _19 = @"
****************************************************************************************////////////////////////////////
********************************************************************************************////////////////////////////
****************,*,,,**,,,,,,,,,,,,,,,,,,,,,,,**,****************************************************/*/////////////////
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,****************************************///////////////
****,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,************************************///////////
,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************//////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%(,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&&&&%%&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,/%%%%%%%,,,,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,&&&&%%%%,,,,*******/**************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(&&&&&&&&&&&&&&&&&&&&&&@&&&&&*,,,,&&&,,,,%&&&&&&&&&&,,,%***,/(&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&%#&&&&&&@@@@@@@@@@@@@@@&&&,*&&&*,(&@@@@@@@@@&**(&&&&&&&,**&&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/*&&&&&&%%%%%%%&&&@@@@@@@@@@@@@@@@@@&/*****&@@@@@@@@@(////&&&&&&&*****&&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%%%%&,,,,,,,,,,#&%%%%%%%@@@@@@@@@@@@((%@&///@@@@@@@@((((((@@&&&&,,,,***/&******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%##&@@@@@@@@@@@#%@@/(#@@@@&%#####%@@@&&@,,,,,,****(,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(%#%%##@@&(@@@%#%@@(@@@@@%%&@@@@@@@%%,,,,,,,,,**,(,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(#&%%%&%##(#%&@%%%%&@@@@%%%#((/(#&%%#,,,,,,,,,,,,/,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/#%%%%&,%&%#(((/%&@&&&&&@%,,%#(//&&&&&#,,,,,,,,,,(/,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/((##,,,,,,%#(/(,,,,,,,,,,,,,#(//*,%&&#(/,,,,,,,,#/,*****************
,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(##*,,,,,,,,%##(*,,,,,,,,,,,*((((,,,,&%#/,,,,,,**#(,*****************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((,,,,,,,,,,,,(((,,,,,,,,,,,/((,,,,,,,(#(,,,,,*****(*****************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((,,,,,,,,,,,**///,,,,,,,,,*/(,,,,,,,,,,((*,**************************
****************,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(%*,,,,,,,,,,,,**##%*******(((///////////#%#///////////////****//******
****************************,,,,,,,,,,,,,,,,,,/#%%*****,,,,,,,,,,/(%/,,****(%#*,,,,,,,*///#%&*//*********///************
//********************************************,*,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************************/*/////
///////****************************************************************************************************/////////////";
        string _2 = @"
***********************************************************************************************/////////////////////////
********************************,**************************************************************/////////////////////////
****************,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************************///////////////
**********,,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****************************************/////////////
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,**************************************/////////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***************************************//////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&#(*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************//
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&%&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,#%%%%%%#,,*,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,#,,,,,,,/&&&&&%%#,,,******,****************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,&&&*,,,&&&&@@&&&&#,,&&(*%&&&&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&#&&&&&&&@&@@@@@@@@@@@@@@@%*/&&&,,&@@@@@@@@@@***&&&&&&&&**/&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,&(/&&&&%%%&&%%%%@&&&&&@@@@@@@@@@@@@@@/******&@@@@@@@@@/////&&&&&&***,*/&,*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,//.,,,,,,,,,,,,/&&%%%%&@@@@@@@@@@@#((@@(//#@@@@@@@@((((((&&&&&,,,*,,,,&,******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#%##@@@@@@@@@@@&(&@@((&@@@@@@@%###(#&@&%,,,,,,,,,*(/**,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%%(@&(%@@@@@&##@@%#@@@@%#%%##&@@&&#,,,,,,,,,,,**(******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&(((##%%&&&@@%%%%@@@@@%%%&%%&%(//***,,,,,,,,,,,#******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((((###&#,,,,,*/#%&&%,,,,@&&&&&&%#(/*/,,,,,,,,,#(*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((((#,,,,,,,,,,,,,,,,,,,,,,&%%(%&%((/,,,,,,**,*#(****************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(###%(*,,,,,,,,,,,,,,,,,,,,(#(,,,*((,,,,,,,****%#/***************
********,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((,,%#(*,,,,,,,,,,,,,,,,,,(#,,,,*(/,,**,,***********************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*///**/((##(***************/((/////#(/****************************
************************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/##*,,,,,,****************/(#///////((%%#///////////****//*******/
********************************,***,,,,,,,,,,,,,,,,/(#%******,,,,,,,,,,,,,,,,,/#%%//*******/%//******************//////
/////*****************************************************,,,,,,,,,,,,,,,,,,,,,*,******************************/////////
&&&&&&&@@&&&%%%####(((/************************************************************************************/////////////";
        string _20 = @"
****************************************************************************************////////////////////////////////
********************************************************************************************////////////////////////////
****************,**,,,,,,,,,,,,,,,,,,,,,,,,*****,****************************************************/*/////////////////
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****,****************************************///////////////
****,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,************************************///////////
,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************//////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************//
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&%%%&&&&&&&&&&&&&&,,,,,,,,,,,,,,,/%%%%%%%,,,,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,&&&&%%%%,,,,**********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&&&&&&&&&&&&&&&&&&&&&&@&&&&&*,,,,&&&*,,,&&&&&&&&&&&,,,%****(#&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.&&&&&&&&#%&&&&&&@@@@@@@@@@@@@@@&&&,*&&&*,%&@@@@@@@@@%**#&&&&&&&**,&&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/*&&&&&&%%%%%%%&&&@@@@@@@@@@@@@@@@@@%/*****@@@@@@@@@@/////&&&&&&#,****%&,******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%%%&,,,,,,,,,,/&%%%%%%%@@@@@@@@@@@@((&@&///@@@@@@@@#(((((&@&&&#,,,,****&******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%%##&@@@@@@@@@@@#%@@((%@@@@%%#####%@@@&@@,,,,,,***,#,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(%%%%%#@@##@@@%#&@&(@@@@@%%@@@@@@@&%%,,,,,,,,,,,,(,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(#&%%&&%#((#%&@%%%%&@@@@%%%#((/(#&%%%,,,,,,,,,,,,/,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(#%%%&,/%##((/,/%&@&&&&&*,*%#(//&&&&&%/,,,,,,,,,(/,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(((#,,,,,,#(((/,,,,,,,,,,,,,%(///,#&&%((,,,,,,,*(/,*****************
,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/###,,,,,,,,%##(,,,,,,,,,,,,,((((,,,,(%##,,,,,,*/#(******************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((*,,,,,,,,,,*((*,,,,,,,,,,,/(#,,,,,,,,#(*,,,,***//******************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/((,,,,,,,,,,**///*,,,,,,,,,/(,,,,,,,,,,/(/,**************************
****************,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(&*,,,,,,,,,,,**##%********(((///////////%%#//////////////*****/******
**************************,,,,,,,,,,,,,,,,,,,,,/#%%/***,,,,,,,,,,((#%,,***,,%%(,,,,,,,*///##&%//*********/(/************
//******************************************,*,*,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********************************/*/////
///////****************************************************************************************************/////////////";
        string _21 = @"
****************************************************************************************////////////////////////////////
*********************************************************************************************///////////////////////////
****************,**,,,,,,,,,,,,,,,,,,,,,,,,,,,**,******************************************************/////////////////
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,****************************************///////////////
****,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,************************************///////////
,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************//////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%/,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************//
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/&&&&&%%&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,/%%%%%%%,,,,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,&&&&&%%%,,,,*******/**************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&&&&&&&&&&&&&&&&&&&&&&&&&&&&(,,,,&&&/,,,&&&&&&&&&&&,,*&****#%&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&#%&&&&&&@@@@@@@@@@@@@@@@&&**&&&,,%&@@@@@@@@@%**#&&&&&&&**,@&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/*&&&&&&%%%%%%%&&&@@@@@@@@@@@@@@@@@@%/*****@@@@@@@@@@/////&&&&&&#,****(&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%%%%&,,,,,,,,,,*&&%%%%%%@@@@@@@@@@@@((&@%///@@@@@@@@#((((#&@&&&#,,,,****&******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(%##%@&@@@@@@@@@##@@((%@@@@%%#####&@@@@&&,,,,,,,***#**,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/%%%%%#@@#&@@@%#&@&(@@@@@%%@@@@@@@&%%*,,,,,,,,,,*(,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(&&%%&%#(##&&@&%%%&@@@@%%%#((/(#&%%%,,,,,,,,,,,,/,,****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/#%%%%,*%#(((,,*#%@&&&&&*,,&#(//&&@&&%(,,,,,,,,,(/,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((#/,,,,#(((/,,,,,,,,,,,,,,(((//,(&&%#/,,,,,,,,(/,*****************
,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(##*,,,,,,%###*,,,,,,,,,,,,,((((,,,,,&##*,,,,,,/#(******************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((,,,,,,,,,,#((,,,,,,,,,,,,,/(,,,,,,,,##(,,,,****(******************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((*,,,,,,,,,**((/*,,,,,,,,,*/(,*,,,,,,,,((***************************
****************,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/(&*,,,,,,,,,,,*##%/*******/#(///////////#%#//////////////*****/******
**************************,,,,,,,,,,,,,,,,,,,,,,/#%%/***,,,,,,,,,,(#%/****,,/%#*,,,,*,**///(%&#//********///************
//******************************************,*,*,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************///////
///////****************************************************************************************************/////////////";
        string _22 = @"
****************************************************************************************////////////////////////////////
*********************************************************************************************///////////////////////////
****************,**,,,,,,,,,,,,,,,,,,,,,,,,,,,**,******************************************************/////////////////
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,****************************************///////////////
****,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,************************************///////////
,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************//////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************//
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&%%%&&&&&&&&&&&&&&,,,,,,,,,,,,,,,/%%%%%%%,,,,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,&&&&%%%%,,,,**********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&&&&&&&&&&&&&&&&&&&&&&&&&&&&/,,,,&&&*,,,&&&&&&&&&&&,,,%***,(#&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&#%&&&&&&&@@@@@@@@@@@@@@@&&,*&&&,,%&@@@@@@@@@%**(&&&&&&&***@&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/&&&&&&%%%%%%%&&&@&@@@@@@@@@@@@@@@@%/*****@@@@@@@@@@/////&&&&&&%**,**(&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%%#&*.,,,,,,,,(&%%%%%%%@@@@@@@@@@@@((%@&///@@@@@@@@((((((&@&&&%,,,,****&******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#%##%@@@@@@@@@@@(%@@((%@@@@&&#####%@@@&&&,,,,,,,**,#**,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/%%%%#%@&#@@@@%#%@&(@@@@@%%%@@@@@@@%%*,,,,,,,,,,*#******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(&&%&%##(#%&&@%%%%&@@@@%%%#((/((&%%%,,,,,,,,,,,,(,,,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(#%%%%%#((((,*(&&&&&&&@(,*&#(/*(&&&&%#,,,,,,,,,*/******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(((#,,,#(((/,,,,,,,,,,,,,,,,#(//*#&&%#(*,,,,,,,(/******************
,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(##,,,,,%###(,,,,,,,,,,,,,,,(((*,,,,&##/,,,,,,*((,*****************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((,,,,,,,,,((/,,,,,,,,,,,,,/(#,,,,,,,/#(,,,,****(******************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((,,,,,,,,,**((/,,,,,,,,,,,//*,,,,,,,,,#(/,*,***********************
****************,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(#&*,,,,,,,,,,,#((/********(((///////////%%#/////////////*****(******
**************************,,,,,,,,,,,,,,,,,,,,,,,*#%%*****,,,,,,,,/#%/***,,,,##(*,,,,*,**///#%&(/*********///***********
//**************************************,***,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******************************///////
///////*****************************************************************************************************////////////";
        string _23 = @"
****************************************************************************************////////////////////////////////
*********************************************************************************************///////////////////////////
****************,**,,,,,,,,,,,,,,,,,,,,,,,,,,,**,******************************************************/////////////////
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,****************************************///////////////
****,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,************************************///////////
,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***************************************//////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%(,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************//
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&%%&&&&&&&&&&&&&&&/,,,,,,,,,,,,,,*%%%%%%%,,,,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,&&&&&%%%,,,,**********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(&&&&&&&&&&&&&&&&&&&&&&&&&&&&#,,,,&&&(,,,&&&&&&&&&&&,,,&(**/%%&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.&&&&&&&&#%&&&&&&&&@@@@@@@@@@@@@@&&,,&&&,,#&@@@@@@@@@%**/&&&&&&&**,&&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/*&&&&&&%%%%%%%&&&@@@@@@@@@@@@@@@@@@&/*****&@@@@@@@@@/////&&&&&&&**,***&/******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/%%%&,,,,,,,,,,,%&%%%%%%@@@@@@@@@@@@((%@&///@@@@@@@@((((((@@&&&%,,,,***,&,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*%###@@@@@@@@@@@(#@@((%@@@@&@#####&@@@@&%,,,,,,,**,#/*,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%%%%#@%(&@@@@%#%@@(@@@@@%%#@@@@@@&%%,,,,,,,,,,,,#******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&%#####%&&&@&%%%&@@@@%%%##(//(&%%%,,,,,,,,,,,,(*,,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(#%%##(#%%*,,*(%&&&&&&*,,@%#(/*&&&&%#,,,,,,,,,*/******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((#(((((,,,,,,,,,,,,,,,,,,/#(//,&&%((,,,,,,,,(//*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/##*,#%((/,,,,,,,,,,,,,,,,,*((#,,,,&#(,,,,,,,*((,*****************
****,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(/,,,,,*(//,,,,,,,,,,,,,,,/((,,,,,,##/,,,,,***/******************
**********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((,,,,,,,*(##(,,,,,,,,,,,,*//,,,,,,,*((***,***********************
****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(##,,,,,,,,,,(%%/*********/#(//////////%#(/////////////*****/******
**************************,,,,,,,,,,,,,,,,,,,,,,,,,/#%%****,,,,,,,,(,***,,,,,,,%#(,,,,,,*///*%&&/*********(/************
//**************************************,*,*,*,*,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******************************///////
///////*****************************************************************************************************////////////";
        string _24 = @"
***************************************************************************************/////////////////////////////////
*********************************************************************************************///////////////////////////
****************,*******,,,,,,,,,,,,,,,,,*******,******************************************************/////////////////
************,,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,****************************************///////////////
********,,,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************************************///////////
,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***************************************//////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,***********************************////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#/,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&%%%&&&&&&&&&&&&&&,,,,,,,,,,,,,,,/%%%%%%%,,,,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,&&&&%%%%,,,,**********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&&&&&&&&&&&&&&&&&&&&&&&&&&&&/,,,,&&&*,,,&&&&&&&&&&&,,*%****#%&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&#%&&&&&&&&@@@@@@@@@@@@@&&&**&&&,,%&@@@@@@@@@%**#&&&&&&&***@&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/*&&&&&&%%%%%%%&&&@&@@@@@@@@@@@@@@@@%/*****@@@@@@@@@@/////&&&&&&%**,**%&,******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%%%%%,,,,,,,,,,/&%%%%%%%@@@@@@@@@@@@((&@&///@@@@@@@@((((((&&&&&%,,,,****&******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#%##&@@@@@@@@@@@(%@@((%@@@@&@#####%&@@@&/,,,,,,,***#,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/%%%(&&(#@@@@@%#%@@(@@@@@%%#@@@@@@@%#,,,,,,,,,,,,(,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&###(#%%&&&@%%%%&@@@@%%%%#((/(&%%(,,,,,,,,,,,,/,,,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(#%##(#%@&/,,/%&&&&&&@/,,@%#(/*#&&&%(,,,,,,,,,(/,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(((((//,,,,,,,,,,,,,,,,,,,,#(///&&#(*,,,,,,,,(/******************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(##&%((/,,,,,,,,,,,,,,,,,,,(((*,,*%#(,,,,,,*/((******************
****,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((,,,,,(//*,,,,,,,,,,,,,,,,((,,,,,*#/,,,,,,*/********************
**********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((,,,,,,/#(%/,,,,,,,,,,,,,/(*,,,,,,((/,,*,***********************
****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(%*,,,,,,,,,%&(***********(((////////%#(##////////////*****/******
**************************,,,,,,,,,,,,,,,,,,,,,,,,,*/#%%****,,,,,,,,***,,,,,,,,##(*,,,*,*////(&%**********(/************
//**************************************,*,*,*,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******************************///////
///////*****************************************************************************************************////////////";
        string _25 = @"
**************************************************************************************//////////////////////////////////
***********************************************************************************************/////////////////////////
****************,*******,,,,,,,,,,,,,,,,,,,*****,***************************************************//*/////////////////
****************,,,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****,****************************************///////////////
************,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************************************///////////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***************************************//////
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,***********************************////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#/,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&%%%&&&&&&&&&&&&&&,,,,,,,,,,,,,,,/%%%%%%%,,,,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,&&&&%%%%,,,,**********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&&&&&&&&&&&&&&&&&&&&&&&&&&&&/,,,,&&&*,,,&&&&&&&&&&&,,*%****#%&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&#%&&&&&&&&@@@@@@@@@@@@@&&&**&&&,,%@@@@@@@@@@%**#&&&&&&&***@&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/*&&&&&&%%%%%%%&&&@&@@@@@@@@@@@@@@@@%/*****@@@@@@@@@@/////&&&&&&%**,**%&,******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%%%%%,,,,,,,,,,/&%%%%%%%@@@@@@@@@@@@((&@&///@@@@@@@@((((((&&&&&%,,,,,***&******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#%##&@@@@@@@@@@@#%@@((%@@@@&@#####%&@@@&/,,,,,,,,**#,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/%%%(&&##@@@@@%#%@@(@@@@@%%#@@@@@@@%#,,,,,,,,,,,,(,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&###(#%%&&&@%%%%&@@@@%%%%#((/(&%%(,,,,,,,,,,,,/,,,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(#%##(#%@&/,,/%&&&&&&@/,,@%#(/*#&&&%(,,,,,,,,,(/,*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(((((//,,,,,,,,,,,,,,,,,,,,#(///&&#(*,,,,,,,,(/******************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(#%&#((/,,,,,,,,,,,,,,,,,,,(((*,,*%#(,,,,,,*/((******************
****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((,,,,,(//*,,,,,,,,,,,,,,,,((,,,,,*#/,,,,,,*/********************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((,,,,,,/#(%/,,,,,,,,,,,,,/(*,,,,,,((/,**,***********************
****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(%*,,,,,,,,,%&(***********(((////////##(##////////////*****/******
*************************,,,,,,,,,,,,,,,,,,,,,,,,,,*/#%%****,,,,,,,,***,,,,,,,,##(*,,,*,*////(&%**********(/************
//****************************************,*,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,******************************///////
///////*****************************************************************************************************////////////";
        string _26 = @"
***************************************************************************************/////////////////////////////////
*********************************************************************************************///////////////////////////
****************,*******,,,,,,,,,,,,,,,,,,,*****,***************************************************////////////////////
****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************************///////////////
************,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,,,****************************************///////////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************************************//////
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,***********************************////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&#/,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(&&&&&%%&&&&&&&&&&&&&&&*,,,,,,,,,,,,,,/%%%%%%%,,,,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,&&&&&%%%,,,***********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&&(,,,,&&&/,,,&&@&&&&&&&&,,/&#**#%&&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(&&&&&&&&(%&&&&&&&@@@@@@@@@@@@@@@@&**@&&,,&@@@@@@@@@@(**#&&&&&&&**,@&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(/&&&&&%%%%%%%%&&&@&@@@@@@@@@@@@@@@@#/*****&@@@@@@@@@/////&&&&&&(,*,**&&,******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(%%&,,,,,,,,,,,,(&%%%%%%@@@@@@@@@@@@((&@%//(@@@@@@@@(((((#&&&&&/,,,,,**#&******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*%##%#@@@@@@@@@@##@@((&@@@@&@#####&@@@@&,,,,,,,,,*,(******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*%%#(%#(@@@@@@%#&@&#@@@@&%%#@@@@@@&%/,,,,,,,,,,,,/******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,####(#%%&&&&@&%%%&@@@@%%&%#((//&%%/,,,,,,,,,,,*/,,,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((#(##&&/,,,,*(%&&&&#,,,@&%(/*/@&&%/,,,,,,,,,(/******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((((/,,,,,,,,,,,,,,,,,,,,,,%(///&&#(*,,,,,,,,(/,*,***************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(#%%((/,,,,,,,,,,,,,,,,,,,,((((,,(%(,,,,,,,*(((******************
****,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((,,,(///,,,,,,,,,,,,,,,,,/(*,,,,#(*,,,,,**/********************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((*,,,**(#/(%*************///******#(/***************************
****************,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(&*,,,,,,,##%************/#(////////#(#%%///////////*****/*******
*************************,,,,,,,,,,,,,,,,,,,,,,,,,,,(#%%#**,,,,,,,,****,,,,,,,,,#%#*,,***//**/%/*********///************
//****************************************,*,*,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,*,******************************///////
////////*****************************************************************,,*********************************////////////";
        string _27 = @"
***************************************************************************************/////////////////////////////////
*********************************************************************************************///*///////////////////////
****************,*******,***,,,,,,,,,,,,,************************************************************///////////////////
****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************************///////////////
********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************************************///////////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************/*///////
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,***********************************////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%/*.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&&&&&%&&&&&&&&&&&&&&&&/,,,,,,,,,,,,,,/%%%%%%%,,,,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,/,,,,,,,,&&&&&&%%,,,,**********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&&#,,,,&&&(,,,&&@@&&&&&&&,,(&%**%&&&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&(&&&&&&&&@@@@@@@@@@@@@@@@&**@&&,,&@@@@@@@@@@/**#&&&&&&&,*,@&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,/#/&&&&&%%%%%%%%&&&&&@@@@@@@@@@@@@@@@#/*****@@@@@@@@@@/////&&&&&&(,*,**@&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(&%,,,,,,,,,,,,/&%%%%%%@@@@@@@@@@@@((&@%//(@@@@@@@@(((((#&&&&&*,,,,,**&(******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%###%@@&@@@@@@@##@@((&@@@@&@#####&@@@&&,,,,,,,,,**/******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*%%((((#@@@@@@%#&@&#@@@@&%%#@@@@@@&%*,,,,,,,,,,,*/******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((###%%&&&&@&%%%&@@@@%%&%#((//%%%*,,,,,,,,,,,(/,,,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((##%/&&/,,,,*(%&&&&(,,,@&%((**&&&#,,,,,,,,,,(/******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(((#*,,,,,,,,,,,,,,,,,,,,,,##(//&&#/,,,,,,,,*(/,*,***************
**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*#%((/,,,,,,,,,,,,,,,,,,,,,*((#,,&%(,,,,,,,,#((******************
****,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((,,//**,,,,,,,,,,,,,,,,,,*((,,,*#/,,,,,,**/********************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((,,*(#/#%***************//(/***/##/****************************
****************,*,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(&*,,,**%#***************(#(//////(#%&%////////////*****/*******
*************************,,,,,,,,,,,,,,,,,,,,,,,,,,,,/#%%/**,,,,,,****,,,,,,,,,,/%#(,,,**///(#/**********/(*************
//****************************************,*,*,*,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,******************************///////
//////*/****************************************************************************************************////////////";
        string _28 = @"
***************************************************************************************/////////////////////////////////
*********************************************************************************************///*///////////////////////
****************,******,,,,,,,,,,,,,,,,,,************************************************************///////////////////
****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************************///////////////
********,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************************************///////////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************/*///////
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***,**********************************/////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#%(*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&%&&&&&&&&&&&&&&&&/,,,,,,,,,,,,,,/%%%%%%%,,,,**********************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,*,,,,,,,,&&&&&&%%,,,,**********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&&(,,,,&&&(,,,&&@@@@&&&&&,,(&%**%&&&&&&,*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&(&&&&&&&&&@@@@@@@@@@@@@@@&**&&&,,&@@@@@@@@@@/**#&&&&&&&,*,&&%********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((%&&&&%%%%%%%%&&&&&@@@@@@@@@@@@@@@@#/*****@@@@@@@@@@/////&&&&&&(,*,**&&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*%*,,,,,,,,,,,,*&%%%%%%@@@@@@@@@@@&((&@%//(@@@@@@@@((((((@&&&&*,,,,,**&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%##%@@@&@@@@@@@##@@((&@@@@&@#####&@@@&@,,,,,,,,,*(/******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*%((((#@@@@@@@%#&@&#@@@@&%%#&@@@@@&%*,,,,,,,,,,,#*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(((##%%&&&&@@&%%%&@@@@%%&%#((//(%%*,,,,,,,,,,,(*,,,,**************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((#%%%/&&/,,,,*(%&&&&(,,,&&%#(/*#&%#,,,,,,,,,,((******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,####%%#,,,,,,,,,,,,,,,,,,,,,,*#(//&&(,,,,,,,,,/(/******************
**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*#(((,,,,,,,,,,,,,,,,,,,,,,,((#*/&(,,,,,,,,,#((******************
****,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(#(/*/,,,,,,,,,,,,,,,,,,,,,/(*,*%(,,,,,,,,***(******************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*#(/#(#%/*****************/(/**/##(*****************************
****************,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(&***(##,,***************#((////(#%%%/////////////*****/*******
*************************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/#%%/**,,,*****,,,,,,,,,,,,(%#**,**/(/%/***********(/***********/*
//******************************************,*,*,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,*,******************************///////
////*/******************************************************************************************************////////////";
        string _29 = @"
***************************************************************************************/////////////////////////////////
*********************************************************************************************///*///////////////////////
****************,******,,,,,,,,,,,,,,,,,,,******,****************************************************///////////////////
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,,********************************************///////////////
********,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************************************///////////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************//////////
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,**********************************/////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/&#**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&%&&&&&&&&&&&&&&&&*,,,,,,,,,,,,,,(%%%%%%%,,,,**********************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,/,,,,,,,,&&&&&&%%,,,,,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&&(,,,,&&&/,,,&&@@@@@&&&&,,#&%**%&&&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&(&&&&&&&&&@@@@@@@@@@@@@@@&**&&&,,&@@@@@@@@@@/**#&&&&&&&,*,&&(********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((%&&&%%%&%%%%%&&&&&&@@@@@@@@@@@@@@@(/*****@@@@@@@@@@/////&&&&&&/,,,*,&(*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/.,,,,,,,,,,,,*&&%%%%%@@@@@@@@@@@&((&@%//(@@@@@@@@((((((@&&&&*,,,,,*,&,******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%##%@@&@@@@@@@@##@@((&@@@@@@%####&@@@&@,,,,,,,,,*#*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((((#%@@@@@@@%#&@&#@@@@&%%#&@@@@@@%,,,,,,,,,,,,(,******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((((##%%%&&&&@@&%%%&@@@@%%&%##(//(%%,,,,,,,,,,,,/,,,,,**************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((##&&&&&&/,,,,*(%&&&&(,,,&&%#(/*/&%(,,,,,,,,,*(**,,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,###(&&&%,,,,,,,,,,,,,,,,,,,,,,,%(//#%*,,,,,,,,,#((*,,***************
**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#(/(%%,,,,,,,,,,,,,,,,,,,,,,,((((&#,,,,,,,,,,%((******************
****,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(/((,,,,,,,,,,,,,,,,,,,,,,,/((*%(,,,,,,,,****#******************
*************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#%/#%*********************/(//&#(******************************
****************,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(#@&#,,,,,**************/(#(//(##&#(/////////////*****/********
*************************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/#%%/*,****,,,,,,,,,,,,,,,*#%#****/%(/************(/************/
//******************************************,*,*,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,*,******************************///////
////*/******************************************************************************************************////////////";
        string _3 = @"
*********************************************************************************************///////////////////////////
********************************,**************************************************************/////////////////////////
****************,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,,,,,*********************************************//*///////////////
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****************************************/////////////
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,**************************************/////////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************///////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/&#(*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************//
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&%&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,#%%%%%%#,,*,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,#,,,,,,,/&&&&&%%#,,,******,****************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,&&&*,,,&&&&@@&&&&#,,&&(*%&&&&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&#&&&&&&&@&@@@@@@@@@@@@@@@%*/&&&,,&&@@@@@@@@@***&&&&&&&&**/&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,&(/&&&&%%%&&%%%%&&&&&&@@@@@@@@@@@@@@@//*****&@@@@@@@@@/////&&&&&&***,*/&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/*.,,,,,,,,,,,,/&&%%%%&@@@@@@@@@@@#((@@(//#@@@@@@@@((((((&&&&&,,,*,,,,&,******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%%##@@@@@@@@@@@&(%@@((&@@@@@@@%###(#&@&%,,,,,,,,,*#/**,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%%(@&(%@@@@@&##@@%#@@@@%#%%##&@@@&#,,,,,,,,,,,,*(******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&(((##%%&&&@@%%%%@@@@@%%%&%%&%(//***,,,,,,,,,,,#******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((((###&#,,,,,*(%%&&%,,,,@&&&&&&%#(/*/,,,,,,,,,#(*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((((#,,,,,,,,,,,,,,,,,,,,,,&%%#%&%((/,,,,,,,,,*#(****************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(###%(*,,,,,,,,,,,,,,,,,,,,(#(,,,*((,,,,,,*****%#/***************
********,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((,,%#(*,,,,,,,,,,,,,,,,,,(#,,,,*(/,,**,,,**********************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*///**/((##(***************/((/////#(/****************************
************************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/##*,,,,,,****************/(#///////((%%#///////////****//********
********************************,,,,,,,,,,,,,,,,,,,,/(#%******,,,,,,,,,,,,,,,,,/#%%//*******/%*/******************//////
/////*****************************************************,,,,,,,,,,,,,,,,,,,,,******************************///////////
&&&&&&&@@&&&%%%####((//************************************************************************************/////////////";
        string _30 = @"
**************************************************************************************/////////////////////////////////(
****************************************************************************************////////////////////////////////
********************************,*******,*********************************************************//////////////////////
****************,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***,**********************************************////////////////////
********,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***************************************///////////////
********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////////////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,********************************///////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&#,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************///
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&%&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,#%%%%%%%,,************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,,,,,,,,,*&&&&&&%%,,************************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,&&&*,,,&&@@@@&&&&&,*%&#**%&&&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.&&&&&&&&&(&&&&&&&&&@@@@@@@@@@@@@@@&**&&&,,&@@@@@@@@@@/**%&&&&&&&***&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,((/&&&&%%%&%%%%%&&&@&@@@@@@@@@@@@@@@@(/*****@@@@@@@@@@/////&&&&&&/****/&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*.,,,,,,,,,,,,(&%%%%%%@@@@@@@@@@@%((@@%//(@@@@@@@@((((((@&&&&****,**/&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(%##@@@%@@@@@@@&#%@@((&@@@@@@&####%&@@&@,,,***,***(*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((((##@@@@@@@@%#&@&#@@@@&%%##@@@@@@%,,,,,,,,,***/*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(((##%%&&&&&&@@%%%%&@@@@%%%%%#(//(%%,,,,,,,,,,,*/,,*****************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((##(#&&&&@@%,,,*#&&&&&&%,,,@&&#(/**@#,,,,,,,,,*((,******************
**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/##((,#&&&#,,,,,,,,,,,,,,,,,,,,,,&#(/(#,,,,,,,,**#(/**,***************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(//,#&%,,,,,,,,,,,,,,,,,,,,,,,,#(#%*,,,,,,,,**%((******************
********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(/*,#(,,,,,,,,,,,,,,,,,,,,,,,,((%(,,,,,,,*****/(******************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#%/%&(**********************/(/%#********************************
****************,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**#%&&*,,,,,*************///#(((%(##////////////////****/********
*****************************,,,,,,,,,,,,,,,,,,,,,,,,,,,/%&%/***,,,,,,,,,,,,,,,,,,/%#(*/#%////***********/(*********////
//********************************************,*,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,****************************/////////
/////////**************************************************************************************************/////////////";
        string _31 = @"
**************************************************************************************/////////////////////////////////(
****************************************************************************************////////////////////////////////
********************************,*******,*********************************************************//////////////////////
****************,*,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************************////////////////////
********,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************************************///////////////
********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////////////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************///////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/&(/,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************///
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&&&&&%%&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,%%%%%%%(,,************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,,,,,,,,,*&&&&&%%(,*************************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,*&&&,,,,&&&&&&&&&&%**#&***%&&&&&(**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.&&&&&&&&&#&&&&&&&&&@@@@@@@@@@@@@&&&*%&&&,,&&@@@@@@@@&(**&&&&&&&&**@&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,#(/&&&&&%%%%%%%%&&&@@@@@@@@@@@@@@@@@@/******@@@@@@@@@@/////&&&&&&/****&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,//.,,,,,,,,,,,(&%%%%%%@@@@@@@@@@@@@((@@%///@@@@@@@@((((((&&&&&(***,**&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%#@@@&@@@@@@@@#(@@@((&@@@@@@@######@@&&**,***,**#********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(((((#@@@@@@@@@##&@&(@@@@@#%##%@@@@@%*,,,,,,,,,*#********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/((((##%%&&&&&&%@@%%%%@@@@@%%&%%@%(/(%%,,,,,,,,,,,(*,,*****************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(/((#%(,,,%&&@&&&&(%&@&&&&&&@#,*&&%#((/*&/,,,,,,,,,*(/*******************
**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,##(/,,,,,#&&&%,,,,,,,,,,,,,,,,,,,,,&%(//*,,,,,,,,*,(/,******************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((/,,,,,,#%##,,,,,,,,,,,,,,,,,,,,,,##((,,,,,,,,,**%(#******************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,///,,,,,,/((,,,,,,,,,,,,,,,,,,,,,*(((*,,,,,,,*****#(******************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*#(#*%,,,,*((*,****,,,,,,,,,,,,,,*((((,,,,,,***************************
******************,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***(#%,,,,/#%(,,,,**************//((((/////////////////////***/********
****************************,,,,,,,,,,,,,,,,,,,,,,*,,,,,***#%%/***,,,,,,,,,,,,,,,**%(/(///**///**********/(*********////
//******************************************,*,*,*,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,,*,************************/*///////
///////****************************************************************************************************/////////////";
        string _32 = @"
**************************************************************************************/////////////////////////////////(
****************************************************************************************////////////////////////////////
********************************,*******,*********************************************************//////////////////////
******************,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************************////////////////////
********,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************************************///////////////
********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////////////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************///////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/&(/,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************///
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&&&&&%%&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,%%%%%%%(,,************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,,,,,,,,,*&&&&&%%(,*************************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,*&&&,,,,&&&&&&&&&&%**#&***%&&&&&(**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.&&&&&&&&&#&&&&&&&&&@@@@@@@@@@@@@&&&*%&&&,,&&@@@@@@@@@(**&&&&&&&&**@&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,#(/&&&&&%%%%%%%%&&&@@@@@@@@@@@@@@@@@@/******@@@@@@@@@@/////&&&&&&/****&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,//.,,,,,,,,,,,(&%%%%%%@@@@@@@@@@@@@((@@%///@@@@@@@@((((((&&&&&(***,**&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%#@@@&@@@@@@@@#(@@@((&@@@@@@@######@@&&**,***,**#********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(((((#@@@@@@@@@##&@&(@@@@@#%##%@@@@@%*,,,,,,,,,*#********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/((((##%%&&&&&&%@@%%%%@@@@@%%&%%@%(//%%,,,,,,,,,,,(*,,*****************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(/((#%(,,,%&&@&&&&(%&@&&&&&&@#,*&&%#((/*&/,,,,,,,,,*(/*******************
**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,##(/,,,,,#&&&%,,,,,,,,,,,,,,,,,,,,,&%(//*,,,,,,,,*,(/,******************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((/,,,,,,#%##,,,,,,,,,,,,,,,,,,,,,,##((,,,,,,,,,**%(#******************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,///,,,,,,/((,,,,,,,,,,,,,,,,,,,,,*(((*,,,,,,,*****#(******************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*#(#*%,,,,*((*,****,,,,,,,,,,,,,,*((((,,,,,,***************************
******************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***(#%,,,,/#%(,,,,**************//((((/////////////////////***/********
****************************,,,,,,,,,,,,,,,,,,,,,,*,,,,,***#%%/***,,,,,,,,,,,,,,,**%(/(///**///**********/(*********////
//******************************************,*,*,*,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,**,,*,************************/*///////
///////****************************************************************************************************/////////////";
        string _33 = @"
**************************************************************************************/////////////////////////////////(
***************************************************************************************/////////////////////////////////
********************************,*******,*********************************************************//////////////////////
********************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************************/////////////////////
************,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************************************///////////////
**********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////////////
******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************///////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&#/,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(&&&&&%&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,%%%%%%&(,,************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&%,,,,,,,,,,,,,*&&&&&%%(,*************************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,*&&&,,,,%&&&&&&&&&%**(&***%&&&&&/**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&#&&&&&&&&&@@@@@@@@@@@@@&&%*%&&&,,&&@@@@@@@@&(**&&&&&&&&**@&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((&&&&&%%%%%%%%&&&@@@@@@@@@@@@@@@@@@/******@@@@@@@@@@/////&&&&&&(****&%********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*.,,,,,,,,,,,#&%%%%%%@@@@@@@@@@@@@((@@&///@@@@@@@@#(((((&&&&&#***,**&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%#@@@@@@@@@@@@#(@@@((%@@@@@@@######@@&&(*,***,**#,*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((((((#@@@@@@@@@##&@@(&@@@@#%###@@@@@@/,,,,,,,,,*(,*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((((##%%%&&&&%%%@@%%%#@@@@@%%%%%@@#//#%*,,,,,,,,,,(,,,*****************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,//((#%%%*,,*&&@&&&@%&&@&&&&&&@&,*&&&%#(/*(*,,,,,,,,,,(********************
**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*##(,,,,,,,,#&&%%,,,,,,,,,,,,,,,,,,,,&%(//(*,,,,,,,*,((*******************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(/(,,,,,,,,###/,,,,,,,,,,,,,,,,,,,,*%#((*,,,,,,,,**%#(******************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,//*,,,,,,,,,/((,,,,,,,,,,,,,,,,,,,*((((#,,,,,,,*****#/******************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((,,,,,,,,,*((******,,,,,,,,,,,**#(//(*,,,,,***************************
******************,,,,,,,,,,,,,,,,,,,,,,,,,,,,***%(#,,,,,,,,/#&/,,,************//(/(/(((////////////////////**//********
****************************,,,,,,,,,,,,,,,,,,*,,,(,,,****,*#%%****,,,,,,,,,,,,**(#%,//(/***////*********/(*********////
//********************************************,*,*,*,*,,,,,,,,,,,,,,,,,,,,,,,,,,,***,**************************/*///////
///////****************************************************************************************************/////////////";
        string _34 = @"
**********************************************************************************/////////////////////////////////////(
***************************************************************************************/////////////////////////////////
********************************,*******,*********************************************************//////////////////////
***********************,,,,,,,,,,,,,,,,,,,,,,,,,,***************************************************////////////////////
************,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************************************///////////////
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////////////
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************///////
,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&#/,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/&&&&&%&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,#%%%%%&(,,************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,,,,,,,,,*&&&&%%%(,*************************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,&&&,,,,#&&&&&&&&&%**(&/**%&&&&&(**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&#&&&&&&&&&@@@@@@@@@@@@@&&&*%&&&*,%&@@@@@@@@&#**%&&&&&&&**@&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((&&&&%%%%%%%%%&&&@@@@@@@@@@@@@@@@@@(******@@@@@@@@@@(////&&&&&&#****&#********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*.,,,,,,,,,,,%&%%%%%%@@@@@@@@@@@@@((&@&///@@@@@@@@%(((((&&&&&%***,**&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&##@@@@@@@@@@@@#(&@@((#@@@@@@@%#####&@&&%,,,,*,**#********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#/(##(#@@@@@@@@@%#&@@(&@@@@#%###&@@@@@#,,,,,,,,,*(,*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/((((##%%&&%%%%%%@@%%%%&@@@@%%%%%@@%(/(%/,,,,,,,,,,(,,,,,,**************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,//(((##%%%/,,&&&&&&&&&&&@&&&&&@&*,&&&%#(/***,,,,,,,,,,(*,******************
**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%###*,,,,,,,,,&&&%#,,,,,,,,,,,,,,,,,,,&&#(//,,,,,,,,,*((*******************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((,,,,,,,,,,,%##/,,,,,,,,,,,,,,,,,,,(%%#(#,,,,,,,,,*##(******************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(/,,,,,,,,,,,,(((,,,,,,,,,,,,,,,,,,((,,((,,,,,,*******/%*****************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/##*,,,,,,,,,,,/#(*****,,,,,,,,,,,/##,,,/(,,,,,***************************
******************,,,,,,,,,,,,,,,,,,,,,,,,,,,,%%#&,,,,,,,,,,,/#&*,,************/#(///(((////////////////////**//********
****************************,,,,,,,,,,,,,,,,,,%*,,,,,***,,,,/#%%****,,,,,,,,,,,&&/,***///****///*********((*********////
//****************************************,***,*,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***,**************************/*///////
///////***************************************************************************************************//////////////";
        string _35 = @"
**********************************************************************************/////////////////////////////////////(
***************************************************************************************/////////////////////////////////
********************************,*******,*********************************************************//////////////////////
***********************,,,,,,,,,,,,,,,,,,,,,,,**,***************************************************////////////////////
************,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,****************************************///////////////
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////////////
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************///////
,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*%(/,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,%%%%%%&/,,************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&#,,,,,,,,,,,,,*&&&%%%%/,,************************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,*&&&,,,,#&&&&&&&&&#**/%***%&&&&&***********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&#&&&&&&&&&@@@@@@@@@@@@@&&%*&&&&*,%&@@@@@@@@&#**%&&&&&&&**&&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((&&&&&%%%%%%%&&&&@@@@@@@@@@@@@@@@@@(******@@@@@@@@@@(////&&&&&&%****&(********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/#,,,,,,,,,,,*&%%%%%%%@@@@@@@@@@@@@((&@&///@@@@@@@@&(((((&&&&&&***,**&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&##&@@@@@@@@@@@#(&@&((#@@@@@@@%#####%@&&&,,,,,,**#********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(/#%%((@@@@@@@@@%#&@@(&@@@@%%###&@@@@@#,,,,,,,,**(********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*//(((###%&&%%%%%%@&%%%%@@@@@%%%%%@@@(/(%*,,,,,,,,,,(,,,,,,**************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,//((((##%%#,/@&@&&&&@&&@@&&&&@@@(/&&%%#(/**/,,,,,,,,,*(********************
**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#((#/,,,,,,,,,&&&%#,,,,,,,,,,,,,,,,,,,&&#(//,,,,,,,,,,((*******************
****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((,,,,,,,,,,,%##/,,,,,,,,,,,,,,,,,,,#%#(((,,,,,,,,,*##(******************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(/,,,,,,,,,,,,(((,,,,,,,,,,,,,,,,,,((,,((*,,,,,,*****/(#*****************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((,,,,,,,,,,,,/#(,***,,,,,,,,,,,,/#(*,,/(*,,*,***************************
****************,**,,,,,,,,,,,,,,,,,,,,,,,,,,,(#/#,,,,,,,,,,,/#%*,,***********//((////((/////////////////////**(********
****************************,,,,,,,,,,,,,,,***%/,,,,,,***,,,/#%%,***,,,,,,,,,**%&#,***//(****////********(/*********////
//****************************************,*,*,*,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,***,/((***********************/////////
//////*******************************************************************,,*******************************//////////////";
        string _36 = @"
**********************************************************************************/////////////////////////////////////(
***************************************************************************************/////////////////////////////////
********************************,**************************************************************/////////////////////////
****************,******,,,,,,,,,,,,,,,,,,,,,,,**,***************************************************////////////////////
************,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,****************************************///////////////
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************////////////
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************///////
,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&//,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&&&&&&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,%%%%%&&*,,************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&/,,,,,,,,,,,,,*&&&%%%%/,,************************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,/&&&,,,,#&&&&&&&&&(,*/#,**#&&&&&***********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&#&&&&&&&&&@@@@@@@@@@@@@&&#*&&&&*,%&@@@@@@@@&#**&&&&&&&&**&&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,&(/&&&&&%%%%%%%&&&&@@@@@@@@@@@@@@@@@@(******@@@@@@@@@@(///*&&&&&&%****&%********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&&#,,,,,,,,,,#&%%%%%%%@@@@@@@@@@@@@((%@&///@@@@@@@@@(((((&&&&&&***,**&,*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&##%@@@@@@@@@@@#(&@&((#@@@@@@@&######@&&&,,,,*,**%********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/@@@##@@@@@@@@@%#&@@(&@@@@%%####@@@@@%,,,,,,,,**#********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,//((((##&@@&%%%%%@&%%%%@@@@@%%%%%@@@#/(%*,,,,,,,,,,(*,,,,***************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/(((((#%%%#&@@@&&&@&&@@&&&&@@@##&&%%#((**/,,,,,,,,,,((*******************
**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,//((##,,,,,,,,&&&%#,,,,,,,,,,,,,,,,,,,&&#(/*/,,,,,,,,*((*******************
****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(##,,,,,,,,,,,%##(,,,,,,,,,,,,,,,,,,*##*#((*,,,,,*,,**#(******************
********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((,,,,,,,,,,,,(((,,,,,,,,,,,,,,,,,(#/,,(((*,,,,,*,***/((*****************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,//(,,,,,,,,,,,,,((/***,,,,,,,,,,,*##/,,,*(/,,*,***************************
****************,**,,,,,,,,,,,,,,,,,,,,,,,,,,/(&,,,,,,,,,,,,,,/#%*,**********//((/////(((////////////////////**(********
***************************,,,,,,,,,,,,,,,,/(%&,,,,,,,****,,,(#%(,***,,,,,,,,,#&#,,,,*/*/****////********///*********///
//****************************************,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****#%#************************///////
/////*****************************************************************************************************//////////////";
        string _37 = @"
*******************************************************************************/**////////////////////////////////////((
***************************************************************************************/////////////////////////////////
***********************************************************************************************/////////////////////////
**************************,,,,,,,,,,,,,,,,,,*******************************************************/////////////////////
****************,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,**************************************/////////////////
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************/////////////
********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************/*///////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,***********************************////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&&&&%&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,%%%%%&&*,*************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&(,,,,,,,,,,,,,*&&&&%%%/,,***********************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,/&&&,,,,#&&&&&&&&&/,*/#,**%&&&&&***********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&&&&&&&&#&&&&&&&&&@@@@@@@@@@@@@&&#*&&&&*,#&@@@@@@@@&#**&&&&&&&&**@&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,%/(&&&&&&%%%%%%&&&&@@@@@@@@@@@@@@@@@@(******@@@@@@@@@@(///*&&&&&&%****&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%%&,,,,,,,,,,%&%%%%%%%@@@@@@@@@@@@@((&@&///@@@@@@@@@(((((%&&&&&,**,**&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&##%@@@@@@@@@@@#(&@&((#@@@@@@@@######@&&&,,,**,**/(*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*@@@%%@@@@@@@@@##&@@(&@@@@%%%###&@@@@&,,,,,,,,,*/(*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((((#%@@@&%%%%@&%%%%@@@@@%%%%%&@@@((%*,,,,,,,,,,//*,*****************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,//(((###%%&&@@&&&@&&@@&&&&@@@(%&&&%##(/**,,,,,,,,,*/(*******************
**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/(((##,,,,,%&&%%,,,,,,,,,,,,,,,,,*(&&%(/*/*,,,,,,***((******************
****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((#,,,,,,,,,&%##,,,,,,,,,,,,,,,,,*(#(,#(((*,,,,,,,**#(******************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(#,,,,,,,,,,,/((*,,,,,,,,,,,,,,,*((,,,,((/,,,,,*,****/(*****************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/(,,,,,,,,,,,,,/#(**,,,,,,,,,,,*(#/,,,,,((*,*****************************
****************,***,,,,,,,,,,,,,,,,,,,,,,,,,/##*,,,,,,,,,,,,,,(#&**********/(#((//////(((///////////////////**/********
***************************,,,,,,,,,,,,,,,,/(%#,,,,,,,,******/(##,,***,,,,,**/##,,,***///(***/////*******/(/********////
//****************************************,***,,,,,,,*,,,,,,,,,,,,,,,,,,,,,,,,,*******/%%%/**********************///////
/////*****************************************************************************************************//////////////";
        string _38 = @"
*******************************************************************************///////////////////////////////////////((
***************************************************************************************/////////////////////////////////
***********************************************************************************************/////////////////////////
***********************,,,,,**,,,,,,,,,,,,,,*******************************************************/////////////////////
****************,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,**************************************/////////////////
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************/////////////
********,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************/*///////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,/,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,***********************************////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&&&&&&&%&&&&&&&&&&&&&,,,,,,,,,,,,,,,%%%%%&%/,*************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&(,,,,,,,,,,,,,,&&&&%%%/,************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,/&&&,,,,(&&&&&&&&&/,**(,**%&&&&&/**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&(%&&&&&&&&@@@@@@@@@@@@@&&#*&&&&/,(&@@@@@@@@&%**&&&&&&&&**@&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,#*%&&&&&&%#%%#&&&&&@@@@@@@@@@@@@@@@@@(******&@@@@@@@@@(///*&&&&&&%****&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%%%&*,,,,,,,,&%%%%%%%%@@@@@@@@@@@@@((%@@///@@@@@@@@@/((((#&&&&&,**,**%%*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&###@@@@@@@@@@@#(&@&(((@@@@@@@@######&&&&,,,**,***#*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&@@&%@@@@@@@@@%#&@@(&@@@@%%@###%@@@@&,,,,,,,,,**(*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((((#@@@&%%%%@@%%%%@@@@@%%#&%%@@@#((*,,,,,,,,,,*(*,*****************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((((###%%&&@&&&&&&@@&&&&@@@%%&&&%##(/**,,,,,,,,,,*((******************
**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((((##,,,/&&&%,,,,,,,,,,,,,,,,*#&&#&#(/**,,,,,,***((******************
****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((((/,,,,,,#&##*,,,,,,,,,,,,,,,,(#(,,*#((*,,,,,,***##/*****************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(##,,,,,,,,,,(((,,,,,,,,,,,,,,,((,,,,,*#(*,,,,*,***,/#*****************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((,,,,,,,,,,,,,/((*,,,,,,,,,,,((/,,,,,,,//******************************
****************,***,,,,,,,,,,,,,,,,,,,,,,,,,,/((*,,,,,,,,,,,,,*##%*********/(((////////(((//////////////////**//*******
***************************,,,,,,,,,,,,,,,,,/%(,,,,,,,,,******/(##*,***,,,*&&&#,,,,**//**/(/**////********/(********////
//****************************************,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,********#&&&/*********************///////
/////*****************************************************************************************************//////////////";
        string _39 = @"
*******************************************************************************///////////////////////////////////////((
**********************************************************************************//***////////////////////////////////(
***********************************************************************************************/////////////////////////
*************************,,,**,,,,,,,,,,,,,,******************************************************//////////////////////
****************,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,**************************************/////////////////
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***************************************/////////////
********,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************/*///////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,***********************************////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(&&&&&%###%%&&&&&&&&&&,,,,,,,,,,,,,,,#%%%%&%(,*************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&&&&&&&&&&&&&&&&&&#,,,,,,,,,,,,,,&&&&%%%#,************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,&&&,,,,,&&&&&&&&&(,**(,**#&&&&&#**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&&&&&&&##&&&&&&&&@@@@@@@@@@@@@&&&*#&&&#,*&@@@@@@@@&&**#&&&&&&&**&&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*%&&&&&&&##%%&&&&&@@@@@@@@@@@@@@@@@@%******%@@@@@@@@@#//**&&&&&&&****(&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&###&&%(((*,,*&%%%%%%%%@@@@@@@@@@@@@((#@@///@@@@@@@@@#/((((&&&&&,**,***&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%##@@@@@@@@@@@#(#@@(((@@@@@@@@&######@&&(,,**,***#*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%@@@#%@@@@@@@@%#%@@(%@@@@&#@&###&@@@&*,,,,,,,,***(******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#(((((@@@&%%%%@@%%%%&@@@@&%%&%%&@@@(((,,,,,,,,,,,*(,*****************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((((##%%&&&&&&&&&@@&&&&@@@&#&&@%##((/**,,,,,,,,,**(******************
**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((((#%,,,,%&&%%,,,,,,,,,,,,,,,#&&@(&#(/*/,,,,,,****((*****************
****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((((#,,,,,,,&###,,,,,,,,,,,,,,*(##*,,,%(((*,,,,,****#(*****************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((#,,,,,,,,,,*(((,,,,,,,,,,,,,(#/,,,,,,##(*,,,*,****/#*****************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((,,,,,,,,,,,,,(((,,,,,,,,,,/((,,,,,,,,,/(*****************************
****************,***,,,,,,,,,,,,,,,,,,,,,,,,,,,*((*,,,,,,,,,,,,,/###********/#%//////////(((//////////////////**(/******
***************************,,,,,,,,,,,,,,,,,,/%/,,,,,,,,,******/(##*,***,,#%%%,,,,,**//***((/*/////*******/(/*******////
//******************************************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,*******#&&@/******************/*///////
/////*****************************************************************************************************//////////////";
        string _4 = @"
*******************************************************************************************/////////////////////////////
********************************,***********************************************************/****///////////////////////
****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,,,,,*********************************************//*///////////////
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****************************************/////////////
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///////////
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************/*///////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%/*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************//
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&%&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,#%%%%%%#,,*,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/&&&&&&&&&&&&&&&&&&&&&&&&&&%,,,,,*,,,,,,,/&&&&&%%#,,,******,****************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,&&&,,,,&&&&&&&&&&#,,&&/*(&&&&&&%**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&#&&&&&&&@@@@@@@@@@@@@@@@@%*(&&@,,&&@@@@@@@@@***&&&&&&&&**#&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,&(/%&&&%%%&&%%%%&&&&&&@@@@@@@@@@@@@@@/******@@@@@@@@@@/////&&&&&&***,*%&,*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**.,,,,,,,,,,,,(%%%%%%&@@@@@@@@@@@%((@@#//(@@@@@@@@((((((&&&&&,,,*,,,(&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%##@@@@@@@@@@@&(&@@((&@@@@@@@#####%&@&&,,,,,,,,**#*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%%#&@((@@@@@@##@@%#@@@@&#%###@@@&%%,,,,,,,,,,,*(/******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(&##(##%%&&&@@%%%%&@@@@%%%&%%%#(/***,,,,,,,,,,,,(,,****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(###(###@&/,,,,/%&&&&&/,,,@&%&&&&#(///,,,,,,,,,,%(*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(#(((((,,,,,,,,,,,,,,,,,,,,,,%%&#(&(((,,,,,,,,,,,#(****************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,####,,,,,,,,,,,,,,,,,,,,,,*##*,,#(*,,,,,,***,,(##***************
********,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((#(,,,,,,,,,,,,,,,,,,,,,*(/,,*(/*,,,,,,,**********************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*//*#&###******************((/*//#(/*****************************
************************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(#%*,*,,/*****************/(#/////#(###////////////****//********
******************************,,,,,,,,,,,,,,,,,,,,,,,/(#%*****,,,,,,,,,,,,,,,,,,/#%&//***/*##//*******************//////
/////***************************************************,*,,,,,,,,,,,,,,,,,,,,,******************************/*/////////
&&&&&@@@@@@&&&&%%%%##((//*******************************************************************************////////////////";
        string _40 = @"
*******************************************************************************///////////////////////////////////////((
**********************************************************************************//***////////////////////////////////(
***********************************************************************************************/////////////////////////
*************************,,,,,**,******,,*********************************************************//////////////////////
****************,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****************************************/////////////////
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***************************************/////////////
********,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************/*///////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,***********************************////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&&&&&####%&&&&&&&&&&&,,,,,,,,,,,,,,,(%%%&&%(,*************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&%,,,,,,,,,,,,,,&&&&%%%%,**********/*************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,&&&,,,,,&&&&&&&&&#,*,(,**%&&&&&%**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&##&&&&&&&&@@@@@@@@@@@@@&&&*/&&&%,,&@@@@@@@@&&**(&&&&&&&**#&&/********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&&&&&&&%#%%&&&&&@&@@@@@@@@@@@@@@@@&******(@@@@@@@@@%//**&&&&&&&*****&#*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&((#&&&%%%#***&%%%%%%%%@@@@@@@@@@@@@((#@@///@@@@@@@@@%/((((@&&&&,**,***&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%##@@@@@@@@@@@#(#@@/((@@@@@@@@@######&&&@****,****(******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&@@@##@@@@@@@@&##@@(%@@@@&#&@###%@@@@&,,****,,***#******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(((((&@@&%%%%@@%%%%%@@@@@%%%%%#@@@%((,,,,,,,,,,,*#/*****************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((((##%%&@&&&&&&&@@&&&&@@@&#&&&%%#((/**,,,,,,,,,**#(*****************
**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/(((##,,,,/&&&%*,,,,,,,,,,,,,*&&%@*#%#(/**,,,,,****((*****************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((((#,,,,,,,#%###,,,,,,,,,,,,,####,,,,*#(((,,,,,****%(*****************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(#/,,,,,,,,,,(((*,,,,,,,,,,,*##,,,,,,,,#(/,***,****/(*****************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((,,,,,,,,,,,,*#(*,,,,,,,,,/((,,,,,,,,,*((****************************
****************,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((**,,,,,,,,,,,,/#%/*******(%#///////////((//////////////////**//******
***************************,,,,,,,,,,,,,,,,,,,/%/,,,,,,,,,******(###,***,,(#%&,,,,,*//****/((//////*******/(/*******////
//******************************************,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,********#&@&/*****************/*///////
/////*******************************************************************************************************////////////";
        string _41 = @"
********************************************************************************//////////////////////////////////////((
**********************************************************************************//***/////////////////////////////////
***********************************************************************************************/////////////////////////
****************************,,**,,,,,,,,,*********************************************************//////////////////////
****************,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****************************************/////////////////
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************/////////////
********,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************/*///////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&&&&&#(((%&&&&&&&&&&&,,,,,,,,,,,,,,,/%%%&&%#,*************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,&&&&%%%%,**********/*************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,&&&,,,,,&&&&&&&&&#**,(,**%&&&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&##&&&&&&&&@@@@@@@@@@@@@&&&*/&&&&,,&&@@@@@@@&&**(&&&&&&&**/&&%********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&&&&&&&&#%%&&&&&@&@@@@@@@@@@@@@@@@&******/@@@@@@@@@%//**%&&&&&&*****&&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%((#&%&&&&%(**&%%%%%%%%@@@@@@@@@@@@@(((@@///@@@@@@@@@@/((((&&&&&,**,***&%******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,@%##@@@@@@@@@@@%((@@/((@@@@@@@@@####(#&&&&****,****%******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&@@&#@@@@@@@@&##@@(#@@@@@#&@&###&@@@&*,****,,***(/*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((((##@@&%%%%@@%%%%%@@@@@%%#%%#&@@@((,,,,,,,,,,,,/(*****************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(((##%%&@@&&&@&&&@&&&&@@@&(&&%&%##(//**,,,,,,,,**((*****************
**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((((#/,,,,&&&%%,,,,,,,,,,,,,/&&%@(*&#(/*/*,,,,****((/****************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((((,,,,,,,&###,,,,,,,,,,,,,(###,,,,,%#((**,,,****##(****************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(#,,,,,,,,,,,(((,,,,,,,,,,,*(#,,,,,,,,/#(****,*****/*****************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(*,,,,,,,,,,,,(((,,,,,,,,,/((,,,,,,,,,,((****************************
********************,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/((**,,,,,,,,,,,,##&*******(##////////////((/////////////////***/******
******************************,,,,,,,,,,,,,,,,,/#/,,,,,,,,,*****/(##*,***,,/%&*,,,,*//*****(((//////******/(/*******////
//*******************************************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********#&&&*****************/*///////
//////******************************************************************,***********************************////////////";
        string _42 = @"
********************************************************************************//////////////////////////////////////((
**********************************************************************************//***/////////////////////////////////
***********************************************************************************************/////////////////////////
****************************,,**,,,,,,,,,*********************************************************//////////////////////
****************,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************************///////////////
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************/////////////
********,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************/*///////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&%&&#****/#%&&&&&&&&&,,,,,,,,,,,,,,,*%%%&&%(,*************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,&&&%%%%%,**********/*************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,&&&*,,,,&&&&&&&&&#**,/,**#&&&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&%#&&&&&&&&&@@@@@@@@@@@@&&&**&&&&,,&&@@@@@@@&&**/&&&&&&&/**&&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/&&&&&&&&##%&&&&&@&@@@@@@@@@@@@@@@@@*******@@@@@@@@@&/***%&&&&&&*****@&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%((#&&%&&&&&%#&%%%%%%%%@@@@@@@@@@@@@#((@@///@@@@@@@@@@//(//&&&&&(**,****&******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,@%##@@@@@@@@@@@%#(@@/((@@@@@@@@@%((#((#&&&,***,****#/*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%#@@@#%@@@@@@@@##@@##@@@@@%@@@####&@@@#,****,*****(*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((((#&@@%%%%&@%%%%#@@@@@%##%%##&@@@((,,,,,,,,,,*,(*****************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((((##%%&&@&&&&&@@&&&&@@@@#&&%&%%#((/**,,,,,,,,***((****************
**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(((##*,,,%&&&%,,,,,,,,,,,,,,&&&@%,&%#(**/,,,,*****#(****************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((((,,,,,,&%##(,,,,,,,,,,,,,###*,,,,,%(((*,*,*****##****************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(#,,,,,,,,,,#((*,,,,,,,,,,,/##,,,,,,,,##(***,******/****************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(*,,,,,,,,,,,*#(/,,,,,,,,,/(*,,,,,,,,,,((***************************
********************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/((***,,,,,,,,,*(##/*******(##///////////(((////////////////***(******
*****************************,,,,,,,,,,,,,,,,,,,//*,,,,,,,,,*****((##,,***,,/&%*,,,,**//****###/////*******((/******////
//********************************************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,**********#%&&/*****************///////
//////******************************************************************,***********************************////////////";
        string _43 = @"
********************************************************************************//////////////////////////////////////((
**********************************************************************************//////////////////////////////////////
*********************************************************************************************///////////////////////////
****************************,,**,*,,,,,,,,********************************************************//////////////////////
****************,,,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,********************************************///////////////
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************/////////////
********,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************/*///////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&#&%,,,,,,,*%&&&&&&&&,,,,,,,,,,,,,,,(%%&%#/*,*************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&&&&&&&&&&&&&&&&&%,,,,,,,,,,,,,,&&&%%%%%,************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,&&&,,,,,&&&&&&&&&****,***(&&&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&%#&&&&&&&&&@@@@@@@@@@@@&&&**&&&&,,&&@@@@@@@&&**/&&&&&&&(*/&&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/&&&&&&&&##&&&&&&@&@@@@@@@@@@@@@@@@@*******@@@@@@@@@&/***&&&&&&&*****&&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&((%&&%%&&&&&&%%%%%%%%%@@@@@@@@@@@@@%((@@///@@@@@@@@@@//(//%&&&&%**,****&******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&%##@@@@@@@@@@@%#(@@/(/@@@@@@@@@&((((((&&&(***,****/(*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&#@@@%%@@@@@@@@##@@##@@@@@@@@@%####@@@&,*,,,,*****#*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((((%@@&%%%&@%%%%#@@@@@%##%%###@@@@(,,,,,,,,,,,,#*****************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((###%%&@&&&&@@@&&&&@@@@&&&%@%%%#(//*,,,,,,,,***#(****************
**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((((#*,,&&&%#,,,,,,,,,,,,,,#&&@@*&%#(/**,,,,,****#(****************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((((,,,,,&&#(*,,,,,,,,,,,,,(###,,,,,%#(/(,*,,,***##****************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/##(,,,,,,,,#((,,,,,,,,,,,,,(#*,,,,,,,*#(#**,******#****************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(*,,,,,,,,,,/#(/,,,,,,,,,,/(,,,,,,,,*,,((**************************
********************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/((************(###********(#(///////////(((///////////////**/(******
*****************************,,,,,,,,,,,,,,,,,,,,(*/#*,,,,,,,,****(##/***,,,,#&(,,,,,,*//***/%##////*******/(/******////
//************************************,*,*,*,,,,*((/*,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,********/##%&/****************///////
//////******************************************************************,,,*********************************////////////";
        string _44 = @"
********************************************************************************//////////////////////////////////////((
**********************************************************************************//////////////////////////////////////
*******************************************************************************************/////////////////////////////
********************************,,,,,**,,*********************************************************//////////////////////
****************,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,********************************************///////////////
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************************************////////////
********,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************/*///////
********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,***********************************////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&(&(,,,,,,,,(%&&&&&&&,,,,,,,,,,,,,,,#%&&#/*,,*************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&(,,,,,,,,,,,,,,&&&%%%%%,************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,&&&,,,,,&&&&&&&&&****,***/&&&&&%**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&%#&&&&&&&&&@@@@@@@@@@@&&&&*/&&&&,,&&@@@@@@@&&**/&&&&&&&/*(&&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(&&&&&&&&##&&&&&&@&@@@@@@@@@@@@@@@@@*******@@@@@@@@@&/***&&&&&&&*****&&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&((&&&&%&&&&&&%%%%%%%%%@@@@@@@@@@@@@%((@@///@@@@@@@@@@//(//%&&&&%**,****&******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(&%##@@@@@@@@@@@#((@@/(/@@@@@@@@@%((((((&&&/***,*****(*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&#&@@&&@@@@@@@@##@@##@@@@@@@@@####%@@@&,*,,,,*****#*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((((#@@@&%%&@%%%%#@@@@@%##%%###@@@&(,,,,,,,,,,,,#/****************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((((##%%@&&&&&@@@&&&&@@@&&&&%&%%%#(/***,,,,,,,,**#(****************
**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((((#%*&&&&#,,,,,,,,,,,,,,,,&&@@,&%#(/***,,,,****#(****************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((((/,,,&&&%(,,,,,,,,,,,,,,,###,,,,,/%(((,,,,,***%#****************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(##,,,,,,,#(((,,,,,,,,,,,,,/##,,,,,,,,#((*,,*****/(****************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((,,,,,,,,,,##(*,,,,,,,,,,*((,,,,,,,,,,#(**************************
********************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*/((***********(#%#*********##///////////((////////////////**/(******
*****************************,,,,,,,,,,,,,,,,,,,,,*/(%*,,,,,,,,***(#%#***,,,,*%%/,,*,,,*//**/((((////******/(/******////
//********************************,*,*,*,*,*,,,,*(##/*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*********#(%@/**************/*///////
//////******************************************************************,,,,,*******************************////////////";
        string _45 = @"
********************************************************************************//////////////////////////////////////((
**********************************************************************************//**//////////////////////////////////
*********************************************************************************************///////////////////////////
********************************,******,,*********************************************************//////////////////////
****************,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*******************************************///////////////
****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************************************////////////
********,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************//*///////
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,***********************************////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&#&#,,,,,,,,*#&&&&&&&,,,,,,,,,,,,,,,#&&%#/,,,*************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&#,,,,,,,,,,,,,,&&&%%%%%,************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,&&&,,,,,&&&&&&&&&*,*******%&&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&&&&&&&#&&&&&&&&&&@@@@@@@@@@&&&&**&&&&,,&&@@@@@@@&&***&&&&&&&#*/&&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&##&&&&&&@&@@@@@@@@@@@@@@@@&*******@@@@@@@@@&/***&&&&&&&*****%&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&((%&&&%&&&&&&%%%&%%%%%@@@@@@@@@@@@@&((@@///&@@@@@@@@@//(//%&&&&&,*,****&******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&%##@@@@@@@@@@@%#(@@((/&@@@@@@@@%((((((&&&/***,****,(*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&##@@@%%@@@@@@@##@@#(@@@@@@@@@####%@@&%,****,*****#*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#(((#&@@&%%%@%%%%#@@@@@%##%%##&@@@((,,,,,,,,,,,,%(****************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((##%%&@&&&&@@@&&&&@@@@&&&%&%%##(//**,,,,,,,,**%(****************
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((((##&&&#,,,,,,,,,,,,,,,,,%@@&(#&%#(/*/,,,,****##/***************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((((#,*&&&%(,,,,,,,,,,,,,,,,(#%#,,,,,&#((,,,,,***##(***************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(##,,,,,,%#(/,,,,,,,,,,,,,,/#/,,,,,,,*((,,,***********************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((,,,,,,,,,(#(,,,,,,,,,,,,/(*,,,,,,,,,((**************************
********************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**/((**********(((/*********(##///////////#((//////////////***//*****
*****************************,,,,,,,,,,,,,,,,,,,,,,**(%*,,,,,,,,***#&/***,,,,,*%%*,***,*///*//((%(///*******((***/**////
//************************************,*,,,,,,,*,*(%%(*,,,,,,,,,,,,,,,,,,,,,,,,,,,************(%//*****************/////
//////******************************************************************,,,,,,******************************////////////";
        string _46 = @"
**************************************************************************/**/////////////////////////////////////////((
**************************************************************************************//////////////////////////////////
*******************************************************************************************/////////////////////////////
********************************,******,,*********************************************************//////////////////////
****************,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,********************************************///////////////
****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************************************////////////
********,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,***********************************//*///////
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,***********************************////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&%&#,,,,,,,,,,/%&&&&&,,,,,,,,,,,,,,,#%%(*,,,,*************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&#,,,,,,,,,,,,,,%&&%%%%%,************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,&&%,,,,,&&&&&&&&&*,*******/%&&&%**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/&&&&&&&#&&&&&&&&&&@@@@@@@@@@&&&%**&&&&,,#&@@@@@@@@&**,&&&&&&&&*/&&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&%#&&&&&&&&@@@@@@@@@@@@@@@@@*******@@@@@@@@@&/***&&&&&&&/****&&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%((#&&&%%&&&&&%%%&&%%%%@@@@@@@@@@@@@@(/%@///%@@@@@@@@@//(//%&&&&&*******&******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.,*,,,,,,,,,,,,,,,,&&%##@@@@@@@@@@@&#(@@((/%@@@@@@@@%((((((&&&****,****,#*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&##&@@%&@@@@@@@##@@%(@@@@@@@@@####&@@&*,****,*****%*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&((((#@@@%%%&%%%%#@@@@@%##%%##@@@%//,,,,,,,,,,,,((****************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((#(##%%@@&&&@@@&&&&@@@@&&&&&%%#(((/***,,,,,,,**((****************
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(((##&&(,,,,,,,,,,,,,,,,,,*@@&%#@&%((//,,,,****/#(***************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(((#%&&%(,,,,,,,,,,,,,,,,,,%%%*,,,,##((,,,,*****%#***************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/###,,,,#%((,,,,,,,,,,,,,,,,(#,,,,,,,,((,,,******/#***************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*((,,,,,,,,(##,,,,,,,,,,,,,/(*,,,,,,,,#(**************************
****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**/(**********((%#**********(##/////////(##(///////////////*/(/*****
****************************,,,,,,,,,,,,,,,,,,,,,,,,*/(&*,,,,,,,,**##******,,,,(##*******/////#%%%////******/(/**/**////
//************************************,*,*,,,,,,,,(%&&#*,,,,,,,,,,,,,,,,,,,,,,,,,,,************/(///***************/////
/////*******************************************************************,**,,,*******************************///////////";
        string _47 = @"
**************************************************************************/**//////////////////////////////////////////(
**************************************************************************************/////////////////////////////////(
*******************************************************************************************/////////////////////////////
********************************,*****************************************************************//////////////////////
****************,***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,********************************************///////////////
****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************************************////////////
********,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,***********************************//*///////
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,***********************************////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&%&#,,,,,,,,,,*(&&&&&,,,,,,,,,,,,,,,%#(/,,,,,*************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&/,,,,,,,,,,,,,,%&&%%%%%,************************************/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,&&(,,,,,&&&&&&&&&,,********(&&&#**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(&&&&&&&#&&&&&&&&&&@@@@@@@@@@&&@(*/&&&&,,#&@@@@@@@@&/**&&&&&&&&*%&&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.&&&&&&&&%#&&&&&&&&@@@@@@@@@@@@@@@@@*******@@@@@@@@@&/***&&&&&&&*****&&*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,%#(#&&&%%&&&&&%%%&&%%%%@@@@@@@@@@@@@@(/%@//*&@@@@@@@@@//(//&&&&&&*******&******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&%%#@@@@@@@@@@@&#(@@((/%@@@@@@@@#(((((&@&&****,*****(*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&##&@@@&@@@@@@@##@@%(@@@@@@&@&###%@@@&,,*,,,,*****#*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&((((#@@@&%%&%%%%#@@@@@%#%%%#%@@&//*,,,,,,,,,,,,#/****************
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(####%%&&&&&@@@&&&@@@@@&&&&&%%##((/**/,,,,,,,**/(****************
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(#((#%(,,,,,,,,,,,,,,,,,,,,@@&%%@#%((//,,,,*****#(***************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((((#&%(,,,,,,,,,,,,,,,,,,,#&&#,,,,##((,,,,*****%#***************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(##*,,,&&#/,,,,,,,,,,,,,,,,(#(,,,,,,/((**,******//***************
************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/((,,,,,,(#((,,,,,,,,,,,,,*((,,,,,,,*((**************************
****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**/((/*******/###************(#(////////%###///////////////*/(******
****************************,,,,,,,,,,,,,,,,,,,,,,,,,*///,,,,,,,,,**/******,,,,,(#(******/////(%%%////*******(/**/**////
//************************************,*,*,,,,,,,,,(%&&/,,,,,,,,,,,,,,,,,,,,,,,,,,,,************////***************/////
/////********************************************************************,,,,,*******************************///////////";
        string _5 = @"
*********************************************************************************************///////////////////////////
********************************,***********************************************************/****///////////////////////
****************,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***,*********************************************//*///////////////
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*****************************************/////////////
****,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///////////
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************/*///////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%*%,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************//
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&%&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,#%%%%%%#,,*,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,*,,,,,,,*&&&&&%%#,,,*******,***************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,&&&*,,,&&&&&&&&&&&,,%&#*/&&&&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.&&&&&&&&&(&&&&&&&@@@@@@@@@@@@@@@@@&*/&&@,,&&@@@@@@@@&***%&&&&&&&**(&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,%(((&&&%%%&&%%%%&&&&&&@@@@@@@@@@@@@@@/******@@@@@@@@@@/////&&&&&&*,*,*&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,(&%%%%%&@@@@@@@@@@@%((@@%//(@@@@@@@@((((((&&&&&*,,,,*,&%*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%##@&@@@@@@@@@&(&@@((&@@@@@@@#####&@@&&,,,,,,,,**(*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%%%#@%(@@@@@@##@@&#@@@@&#%##%@@@&#%,,,,,,,,,,,*#/******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(#&%##(##%&&&@@%%%%&@@@@%%%&%%##(/***,,,,,,,,,,,,/,,,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(##(##(##%&(,,,*(%&&&&&(,,,@&%&&&%#(/*/,,,,,,,,,,%(*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(##//((((,,,,,,,,,,,,,,,,,,,,,(%&%##((*,,,,,,,,,,,#(/***************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(/###*,,,,,,,,,,,,,,,,,,,,,,(##,(((*,,,,,,******%#***************
********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((/,,,,,,,,,,,,,,,,,,,,,,,/(*,(/*,,,,,,,,**********************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,///%%*********************/((//((//*****************************
***********************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(#%,#*********************/#%///(/##//////////////****//********
******************************,,,,,,,,,,,,,,,,,,,,,,,*((#%*****,,,,,,,,,,,,,,,,,,(%%&///*&(///********************//*///
/////***************************************************,*,,,,,,,,,,,,,,,,,,,,,********************************/////////
&&&&&@@@@@&&&&%%%##(((//********************************************************************************////////////////";
        string _6 = @"
*********************************************************************************************///////////////////////////
********************************,****************************************************************///////////////////////
****************,****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,*********************************************//*///////////////
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************************************//////////////
****,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///////////
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************/*///////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%*%,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************//
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&%&&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,#%%%%%%#,,,,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,*,,,,,,,*&&&&&%%%,,,*******,***************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,,&&&*,,,&&&&&&&&&&&,,%&#*/&&&&&&&**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.&&&&&&&&&(&&&&&&&@@@@@@@@@@@@@@@@@&*/&&@,,&&@@@@@@@@&***%&&&&&&&**#&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,%(((&&&%%%&&%%%%&&&&@@@@@@@@@@@@@@@@@/******@@@@@@@@@@/////&&&&&&*,*,*&&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,(&%%%%%@@@@@@@@@@@@&((@@%//(@@@@@@@@((((((&&&&&*,,,,*,&%*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%##@&@@@@@@@@@&(&@@((&@@@@@@@#####&@@&&,,,,,,,,**(***,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%%%#@%(@@@@@@##&@&#@@@@&#%##%@@@&#%,,,,,,,,,,,,#/******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(#&%##(##%&&&@@%%%%&@@@@%%%&%%##(/***,,,,,,,,,,,,/,,,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(##(##(##%&(,,,*(%&&&&&(,,,@&%&&&%#(/*/,,,,,,,,,,%(*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/##//((((,,,,,,,,,,,,,,,,,,,,,(%&%##((*,,,,,,,,,,,#(/***************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(/###*,,,,,,,,,,,,,,,,,,,,,,(##,(((*,,,,,,******%#***************
********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(((/,,,,,,,,,,,,,,,,,,,,,,,/(*,(/*,,,,,,,,**********************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,///%%********************//((//((/////**************************
***********************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(#%,#*********************/#%/////##/////////////*****//********
******************************,,,,,,,,,,,,,,,,,,,,,,,*((#%/****,,,,,,,,,,,,,,,,,,(%%&///*&(///***********************///
/////***************************************************,*,,,,,,,,,,,,,,,,,,,,,********************************/////////
&&&&&@@@@@&&&&%%%##(((//********************************************************************************////////////////";
        string _7 = @"
*******************************************************************************************/////////////////////////////
********************************,****************************************************************///////////////////////
****************,****,,,,,,,,,,,,,,,,,,,,,,,****,*******,*********************************************//////////////////
***********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,****************************************//////////////
****,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///////////
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,************************************/*///////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%,/,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************//
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&%%&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,%%%%%%%(,,,,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&&&&&&&&&&&&&&&&&&#,,,,,,,,,,,,,/&&&&&%%(,,,***********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,/&&&,,,,&&&&&&&&&&%,,#&/**%&&&&&(**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.&&&&&&&&&(&&&&&&&@@@@@@@@@@@@@@@@&#*%&&&,,&&@@@@@@@@&/**&&&&&&&&**&&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,&((#&&&%%%&%%%%%&&&@@@@@@@@@@@@@@@@@@/******@@@@@@@@@@/////&&&&&&,,*,*&%********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,...,,,,,,,,,,,*&%%%%%%@@@@@@@@@@@@&((@@%//(@@@@@@@@((((((@&&&&*,,*,*,&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&###@@@@@@@@@@@%(@@@((&@@@@@@&#####&@&&&,,,,,,,,**/***,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&#%%(@@#%@@@@@##@@&(@@@@&#%##&@@@&%%,,,,,,,,,,,,(*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(%%&%##(##%%&&@@%%%#@@@@@%%%&%##(/***,,,,,,,,,,,,#/,,,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((##(,(##(##&@#*(%&&&&&&&&*,*&&%&&%#(/**,,,,,,,,,,,#/*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*##/(,,(((((,,,,,,,,,,,,,,,,,,,,(%&&#((/,,,,,,,,,,,*#/,***************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(//,(###,,,,,,,,,,,,,,,,,,,,,,*%%(((,,,,,,,,,**,**#(***************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(/(/((,,,,,,,,,,,,,,,,,,,,,,,,#((/,,,,,,,,,***********************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(/*/(*********************/*/(((/********************************
*********************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**/##/*******************////(#((/(/////////////////****//********
****************************,,,,,,,,,,,,,,,,,,,,,,,,,,*((#%******,,,,,,,,,,,,,,,,,#%%(/%#%*///***********************///
///*****************************************************,*,,,,,,,,,,,,,,,,,,,,,********************************/////////
&&&%%%####((///******************************************************************************************///////////////";
        string _8 = @"
*******************************************************************************************/////////////////////////////
********************************,**************************************************************/*///////////////////////
****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,****,*******,*********************************************//////////////////
***********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,,,,,,,****************************************//////////////
****,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///////////
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***************************************//////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%,(,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************//
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&%%&&&&&&&&&&&&&&&,,,,,,,,,,,,,,,%%%%%%%(,,,,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&&&&&&&&&&&&&&&&&&&#,,,,,,,,,,,,,/&&&&&%%(,,,***********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,*&&&,,,,&&&&&&&&&&%,,#&/**%&&&&&(**********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.&&&&&&&&&(&&&&&&&@@@@@@@@@@@@@@@@&#*%&&&,,&&@@@@@@@@&/**&&&&&&&&**&&&*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,&((#&&&%%%&%%%%%&&&@@@@@@@@@@@@@@@@@@/******@@@@@@@@@@/////&&&&&&,,*,*&%********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,*&%%%%%%@@@@@@@@@@@@&((@@%//(@@@@@@@@((((((@&&&&*,,,,*,&********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&###@@@@@@@@@@@%(@@@((&@@@@@@&#####&@&&&,,,,,,,,**/***,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&#%%(@&#%@@@@@##@@&(@@@@&#%##&@@@&%%,,,,,,,,,,,,(,******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(%%&%##(##%%&&@@%%%#@@@@@%%%&%##(/***,,,,,,,,,,,,(/,,,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((##(,(#####@@#*(%&&&&&&&&*,*&&%&&%#(/**,,,,,,,,,,,#/*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*##/(,,((((/,,,,,,,,,,,,,,,,,,,,(%&&#((/,,,,,,,,,,,,#/,***************
*****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(//,(###,,,,,,,,,,,,,,,,,,,,,,*%%(((,,,,,,,,,**,**#(***************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(/(/((,,,,,,,,,,,,,,,,,,,,,,,,#((/,,,,,,,,,***********************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,/(/*/(/********************/*/(((//*******************************
*********************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**/(#/*******************////(#/(/(/////////////////****//********
****************************,,,,,,,,,,,,,,,,,,,,,,,,,,*((#%******,,,,,,,,,,,,,,,,,#%%(/%##*///***********************///
///***********************************************,*,*,*,*,,,,,,,,,,,,,,,,,,,,,********************************/////////
&&&%%%###(((///*******************************************************************************************//////////////";
        string _9 = @"
*****************************************************************************************///////////////////////////////
********************************,************************************************************///*///////////////////////
****************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**,*******,*******************************************////////////////////
***********,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,,,,,,*****************************************//////////////
****,**,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*,************************************///////////
***,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,**************************************//////
,*,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***********************************////
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&%,(,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*************************************//
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&%&&&&&&&&&&&&&&&%,,,,,,,,,,,,,,,%%%%%%%/,,,,*,*********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&&&&&&&&&&&&&&&&&&&/,,,,,,,,,,,,,(&&&&%%%/,,,***********************************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,,,,(&&&,,,,&&&&&&&&&&%,,#%***#%&&&&***********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&&&&&&&&&(&&&&&&&@@@@@@@@@@@@@@@@&(*&&&&,,&&@@@@@@@@&/**&&&&&&&%**&&%*********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,%((%&&&%%%&&%%%%&&&@@@@@@@@@@@@@@@@@@*******@@@@@@@@@@/////&&&&&&,**,,&/********************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,(&%%%%%%@@@@@@@@@@@@&((@@#//(@@@@@@@@(((((%&&&&&,,,*,*,&,*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,&###@&@@@@@@@@@%(@@@((&@@@@&@%####%@@&&&,,,,,,,,*#/***,***************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#&#%%#@@##@@@@@##@@&(@@@@&%%#%@@@@&%%,,,,,,,,,,,,/*******************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,*(%%%&%%####%%&&@@%%%#@@@@@%%%&%#((/**%,,,,,,,,,,,,(*,,,,,*************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(##((,,,##(##&@%/%&@&&&&&&@/,*&%%&&#(/**,,,,,,,,,,,*(/*****************
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,##/,,,,(((((,,,,,,,,,,,,,,,,,,,,#&&%((/,,,,,,,,,**,((/****************
****,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(//,,,,####,,,,,,,,,,,,,,,,,,,,,,%#((,,,,,,,,,,****/#(***************
*******,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,(//,,,/((,,,,,,,,,,,,,,,,,,,,,,,(((,,,,,,,,,,***********************
**************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,((((,,//(********************/*/(((*********************************
*********************,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,***((,/##/******************/////(((///////////////////****/*********
****************************,,,,,,,,,,,,,,,,,,,,,,,,,,,/(##/,****,,,,,,,,,,,,,,,,,/#%(%#/*///*************************//
///***********************************************,*,*,*,,,,,,,,,,,,,,,,,,,,,,,********************************/////////
&&&&&%%%###((///******************************************************************************************//////////////";
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WindowWidth = 120;
        Console.WindowHeight = 28;

        string[] butterfly_frames = new string[] { _1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47};
        for (int i = 0; i < repeats; i++)
        {

            foreach (string butterfly_frame in butterfly_frames)
            {

                Console.WriteLine(butterfly_frame);
                Thread.Sleep(speed);


            }
        }
    }
    static void Home_or_wellspring()
    {
        Central_text("I need to fly home faster than past", 2, 3000);
        Central_text("Or visit my good stone wellspring?", 2, 3000);
        Up_text("a - home / b - wellspring", 3);
        if (Console.ReadKey().KeyChar == 'a')
        {
            Home();
        }
        else if (Console.ReadKey().KeyChar == 'b')
        {
            Wellspring();
        }
        else
        {
            Home_or_wellspring();
        }
    }
    static void Home()
    {
        Central_text("And small butterfly thought about that feelings", 2, 3000);
        Central_text("And nothing about their meanings", 2, 4000);
        Central_text("and first", 2, 400);
        Central_text("and second", 2, 400);
        Central_text("and fourth day away", 2, 800);
        Central_text("She flew to the forest again", 2, 4000);
        Central_text("She saw little ant without the pain", 2, 4000);
        Central_text("And one time she saw him again", 2, 4000);
        Ant();

    }
    static void Wellspring()
    {
        Central_text("She like this weather", 2, 3000);
        Central_text("She like this sun", 2, 3000);
        Central_text("And way to home already began", 2, 3000);
        Up_text("a - usual way / b - ?", 3);
        if (Console.ReadKey().KeyChar == 'a')
        {
            Usual_way();
        }
        else if (Console.ReadKey().KeyChar == 'b')
        {
            Unusual_way();
        }
        else
        {
            Wellspring();
        }

    }
    static void Usual_way()
    {
        Central_text("This way was so close to the sky", 2, 3000);
        Central_text("So she decided to fly", 2, 3000);
        Home();
    }

    static void Unusual_way()
    {
        Central_text("The day was so hard for small butterfly", 2, 4000);
        Central_text("And meanings she saw for a while", 2, 3000);
        Central_text("They changed, she found small ant in a pie", 2, 4000);
        Ant();
    }

    static void Without_ant()
    {
        Central_text("She flew really fast", 2, 2000);
        Central_text("over the grass", 2, 2000);
        Central_text("One movement and everything happend...", 2, 4000);
        Central_text("Here is another lonely ant, she decided to follow him", 2, 7000);
        Ant();
    }

    static void Ant()
    {
        Central_text("This ant traveled a long way and went to unknown place for the butterfly", 2, 7000);
        if (Click_to("Click 'S' very fast to follow the ant",30,"#" ,'s'))
        {
            Central_text("CHAPTER 3: STREET", 1, 5000);
            Street();
        }
    }
    
    static void Street()
    {
        string stre = @"%&%&&&&%%%%&&%%%%%%%&%%%%%&%####%%%%%%,,,/((,%/................................... .,...##((#((((((...    ..*..%&#%&#&%%&@(#@@@@/@#(%(*%#((/*&&@&@#/%@
@&&&&&&@@#@@%%&@@#((%%%#&&&#(###%%%%&%,.,(((,&/............................#............(#((&(/&&((.*#..,.  .#%#&&%&&%%%@&(/&@@&/&(#%*%%&&&@%%&&&&#(/#
@&&&%@@@@#@@@@@@@%(%#%%#@@@%%%%%&%&%@%.../((,@(*(//**,,.........#,.............,,*/#(//*%%#@#@#@@@@&#(#((  . .#%#&&%&@#%@&&/@&##(&@(&%%%/#(&&%&&&#/%@(
@@@@&@&@@&@@@@@@@@&&@@@@%#(/%&%%@%@%&(&(,%@(,&/. ..%*...................... ..,. ....   (#%(#((@%((###(#%%%%@%###@%%@@@#@&@/@@(#%%%(#&&&&%&%(%*&&#(%@(
.,%@@@@&&&&@@&&&&&&&@&@&&&&@%@@@@@@@@#%@@&&&,@/ .....&..........................    ....##(((((@(/((/#&&&&///(%##@#&@@&%%%##((%(###&&%&%%#(&(#*%@#@#@#
#%,../&@@&&@@@@@@###(@@@@@&%(@@(&&@&%%@@@@@&#%&#&&..&@@....................... .        ((((%((@#/(#@(@@%%(*(@&@###%@&&@&(/%%%&%/%%*&%*%&&&&#(%@@#(((%
...&%%..,&@@@@@@@&%%%@@@@@@@&%&@@@@@@@@@@%@@@@%@@&(..& *...........         .          .(%((#&(@#((##,@%##(/@#&###%&&&&&@@(%##&#/#&%%%*&&@/&##*&/(&/&%
...,#&&%#...&@@@@&%%%@@@@@@@@&@@@@@&@@&@@@#(@@@@@@@@(&%#%...                         . .##((#@@@@&(##,@&/(//@#(#(@&%%&&%@%&/&//@/#/*#&*&&&&@%&&%%&&&%%
...*&%%...#%#...%&@@@&@@@@@@@@@@&&@@@@%@@@@@@@@@&@&@%*%.,                        ../. # ####%##%@#%&##%@/@/((#%%#@@&@&@%@%#/@##@(&#%%%*&&&#%##&%&@@//&
...*%%%.....%.....,@@&&&&@%&@@@@@@@&@((@@@@@@@@@@@@@@& .. ..                .(&(#(%&,,&#%#%%@&&&@//##&@@#&(/%&&@&@@&@&@%@@@/@#((#((#%&&%%%&#/(//(&%(/%
.../,/%.....%.........*%&@@@&@@@@@@&@@@@*&@/@@@&@@.#@(*****#.,,/,(..         ##@@%&@%%@###((**%/@%(##@@&&&((#%&@(#%&@&%&%%#%%%#(((#(##%%&&%@@@@@@@%(@/
...(..%.....%...........,@#&&@@@@@@&@@@@&@@@@@@@&&,*@#/*/(&&&@&#((%(.   . * @%#&&(#@##@&&#/#&/@(@#@/#%&&(#/(@##(@#&%%&&&&@((#%@@&&%#((//&@@@@&&@%@#((%
...(..&.....%..........@@@&##&&@@@&&@@&&@@@@@@@@@@(.@/**,*##@&%&#&%#&%(  .%&#%%&&(/%%&@((#%#&#&(@###&@@@(@((@%#%%&&&&&&@&#&&&&&%###@&#&&%&&&%&&&%@#/##
...(..&.....%..........@@@@&@%@@@@#&@&,@*/@/*@@@@&.#@*,*/(%%@&&(#&&%@@,&,%&&&&#%(#%@&&@####%//%(@%(##@@@#&(###@@@&@%#&&@%&%&##&##(#@@@#%(%@@&&&&%@&/#%
...%..%.....%..........(@@@#%@@@@@#&@&@(@&@@@@,(@,..@&&/@(%#@%&&&*((@,...&@@@@@@@@@@@&@#(%@#@#&(@#((##%%&&@@@@@&@%&##@@@&&@&#(%##(%@@@&#%@@@%&&&@@&/(/
...%%@%.....#..........@@@@@@@@@@@%&@@@@@@&#%%&&(.(&@///(,%*@@&@@@@&@%,....@&@&&@@&@@@@####%&&%&@###&&@@@@@@&@@&@%%%%@@@%&@&#(&%(#%@@@##%@@@#&&&@@@%&&
...#%&%....#%..........&@@@@@@@&@@%@@@@@@@@@@@@&#..@@#(&(%##@*&@@(&&(@.....,@#*@@@@@@&&%#%&%/&&&@&&(#@#&@@&@&@@&&%%%&&@&&%%&#(&%#(@@@@(&%@@@(&&&&&&%&%
...#&&%....(%.........,%@@@@@@@@@&%&,%((&/@@&&,,#(*.@#*#(/%#%##&%.@@&. ......@%#@@@@@@&&%%&#@@@@@&%((%##@@%%&@@@@&@%%&@@@%&@%(((((%@@&@(#@@@(&%&&&%&&@
%#######(...%.........,@@@@@@@@&@&%&.%/(&@&#(((,((..@.,,((.   , %/*(*,,,,,..#/(* #%*@@@@*,#.&@@@@@&&%%@&@@@%&%&@@@@#%@@@@@@@#%&%%%@@@@@##@@@(&&@&&&@@&
.%##&&%##%%&/.........,%&//*(@&&@&%@.&&/&@&#/*..(../,(*##%#,%@@,,.,,,.,,. .*##((#*..,,%###@@@#,.#%.,/@@@@@%#@%%@@@@&%@@@@@&@@@@@&@@@@@@%@@@@&@(#((%@%@
.%%%%&%%#.............,&./@@@&@&@@&@.##@@@@@@@@@,&%@.%%(@,.&@,,...,,.,,. .............,/@@@@#%@%%%#@%(**&&%@&&&@@@@&&@@@@@@@@@@&%@@@@&@&@@@@&@#%&&&@#&
...###(...............,%.*#%&%&@@@@&%&@@#(/@/***.@&,*(*@%(&,***,,,..,,,,.......,/#//*,*&#@*@@@@&&&#((@@@@@@@@@@@@@@@@@@@@@@@@@@@&@@@&&@&@@@@@@#%&&&@#&
.......,..............(,./*,#,,,*,/%&&&%&/%@&/&(//**/@%&/**,,,,... ....  .......,...,........,,%@@/@@@@@@%&@@@@@@@@@@@@@@@@@@@@@&@@@&&@@@@@@@&%%&&&@#&
..................,*,.,,,*.//,.,@@@@@@@@@@@@@*@%,&*@@@****/*,,,*,,,,,,,,,........,,,,,.,*....*,,,@@&@@@@@@@@@@&&&&&&&&&&&&&&&&&%%%&&&@@@@@&@@@@@@&@@%@
........ . .,,,,,,,,*,#**/*(/,*,/*(%%%&%%,&(#//@@@@@@*****,,,**,,,,,,,.,...(@%...*,.,,,,,,,.,.,,,,@@@@@@@@@@@@@@@@@&&@@@@@@&@@@@@@@@&&&&&&@@@@&@@@@@&@
. ...,/*,,,,,,,,(,,,,#&&&@&&&&/&&%#%(%.@@@((&#%@@@(*,*,,****,,,*,,,,,,,....%&@ ...*,,,,,*,,*,.....,*,,,,/&@@@@@@@@@&@&&&&&&&&&&&&&@@&@@@@@@@%&@@@@@@@@
,,,,,*,,,,*(*,.&&%,#@@&@@@@@@@@@@& /(#  @@@@@@@//***///*,*,,,.,,,,,,,.,.,..%&%%@@.*,*,,,*,,(##((*....*(,,,,,,(@@@@@@@@@@@&@@&&&&&&&&@&@@@@@&&@@@@@@@@@
*&&**/,,,,.,,,.,.,                    ..@@@@@@@*//*****,,*,.,,.,,,,,,,....%%%@@%.....,..,,,,,*****.....,**,,*/@@@@@@@@@@@@@@&@@&&&&&&&@@@@@@@@@@@&&@@@
,,,,.(. ....,,,* ..  .. ....,,*(   @....#@@*/******/., , ,., ,,, ** ..,..,@@@@@,,..,,,*,,,,*(,,,,,,,......,/,,*,,//&@@@@@@@@@@@@@&&&@&@&&@@@@@@@@@@@@@
.,,**&***,*****/%&/((#/##@&(/((((*,@#,@@&////***,,*,..,.,..,,,,,,,,*,,...,@@@@,,,...*,,,*,,,,,,,,,,.,,,.....*,/,*,*,%@@@@@@@@@@@@@@@@@&@@&@@@@@@@@@@@@
*,,,,@,,,,,,,,@///////%&%/////(@@//@/*,,,*,,,,,,/**,,,,,,.,.,,,,,,,,,.....@@@.,.,,...,,,,,,,,,,,.,.,*,*/,,,...././,, .,*(,,*,/&@@@@@@@@@@@@@&&&&&%&&&&
,,**,@*,,*&@@&&@@@@@@@@@@@@@@@@@@@@#,,,,,,,,,.,,,,.,,,..,.,,,,,,*,,.......@@@@@@.,...,,,,,,,,,.,,,,,,,,,,*,,,,*...,,,/,,,*,,(#&@@@@@@@@@@@@@@@@@@@@@@@
((,,,,,,, ,@@&@@@@@@@&%%(/**/**......,,****,,    ...,,*,*//(   ,   ,,,,,*/@@/*//@@**,(***, ...    *,****,*       .,,,,,,,,.....,**&@@@@&&&&&@@@@@@@@@@
%&&#.((/(//......./#/**,(*.......//*****/*....... ****/(,*  .  .  ,**,,,@@@@....% ../*,,*,*,, .      .**,***,**...,.  .*,,,.,*. . . ..(#*****,..,...%@
////,......,/#,,,,,/,........*/**//*,*.........*,**/*(,*...       /@@@(/*/,.       ..##(&&&%#(*...... .. /(/#**(/#%/*..   ..,*..,,../, . .. ..(&#/#/**
*/*(/*/****//(/,///******/*/,*/*.**/*/*,******,***/*,,/*******/*/,****(***,,*,**,*,***/(*//***/**/,*,../((*/***/**/(*//***//*,*,,,(*.,,..,,/*//(//**/*";
        Console.WindowWidth = 150;
        Console.WriteLine(stre);
        Thread.Sleep(3000);
        Central_text("the butterfly never flew into the city", 2, 3000);
        Central_text("but the atmosphere was oddly familiar", 2, 3000);
        Central_text("she spent the whole day flying through quiet lanes until she met people", 2, 7000);
        Up_text("Choose the door to hide |1|   |2|   |3|", 3);
        string f = Console.ReadLine();
        if (f == "1")
        {
            Central_text("There was a huge dog and everything was interrupted", 2, 3000);
            Fail();
        }
        else
        {
            Central_text("she saw man", 2, 3000);
            Central_text("for him, this environment also seemed new", 2, 4000);
            Man();
        }
    }

    static void Man()
    {
        string man = @"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&&&&&&&&&&&&&&&&&&%%%%%&&&&&&&&&&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&&&&&&&&@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&&&&&&&&&&&&&&&&%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&@@@@&&&&&&&&&@@@@@@@@@@&&&&&&&&&&&&&&&@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&&&&&&&&&&@@@@@@@@@@&&&&&&&&&&&&&&&&&&%%%%%&&&&&&&&&&&&&&&&@&&&&&&&&&&&&&&&&&&&&&&&&@@@@@@@&&&&&&%%%%%&&&&&
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&&&&&&&&&&&&&&&@&@&&@@@&&&&&&&&&&&&&&&&&%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@@@&&&&%%%%%%%%%&&&
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&&%  ,**/***,,,%&&&&@@@@@@@@@@@@@@&&&&&&&&&&&&&&&&&&&&&&@@@&&&&&&&&&&&&&&&%%%%%%&&&&&&&&@@@@&&&%%%%%%%%%%%%%
@@@@@@@@@@&&&&&&&&&&@@@@@@@@@@@@@@@@@@&&&&  ,/*///////**,,..&&&@@@@@@@@@@@@@@&&&&&&&&&&&&&&&&&&@@@@@@@@@@&&&&&&&&&&&%%%%%%%%%%%&&&&&&&&&%%%%%%%%%%%%%%
&&&&&&&&&&&&&&&&&&&&&&&@@@@@@@@@@@@@@&&&,.,*********/***,,   .&&@@@@@@@@@@@@@&&&&&&&&&&&&&&&&&@@@@@@@@@@@@@@&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
&&&&&&&&&&%%%%%&&&&&&&&&&&@@@@@@@@@@@@%//**********/**//*,,..,,@&@@@@@@@@@@@&&&&&&&&&&&&&&&&&&@@@@@@@@@@@@@@@&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%&&&&&&&&@@@@@@@@@@&((///**(//////*******,*,**&@@@@@@@@@@&&&&&&%%%%%&&&&&&&&@@@@@@@@@@@@@@&&&&&&&%%%%%%%#######%%%%%%%%%%%%%%%%%%%%%
###############%%%%%%%%%&&&&&&&&&&&&&&((/*//***/*/*/////**,,****@@@@@@@@@@@&&&&&&&%%%%%%&&&&&&@@@@@@@@@@@@@@&&&&&&%%%%%%##############%%%%%%%%%%%%&&&&
(((###############%%%%%%%%%%%&&&&&&&&&(/((%&&%%#((#%%@&@%##*,,*,*//@@@@@@@&&&&&&&%%%%%%%&&&&&&@@@@@@@@@@@@@@&&&&&&%%%%%################%%%%%%&&&&&&&&&
((((((((((###############%%%%%%%%%%%%#%*%#%(&&&#**/*/(((**/*******(@&%&&@&&&&&&%%%%%%%%%%&&&&&@@@@@@@@@@@@@@&&&&&%%%%%%################%%%%%&&&&&&&&&&
(((((((((((((((((####################%#///***(//****/////*****/,,//@@@@@@(%%%%%%%%%%%%%%%%&&&&&&@@@@@@@@@@@@&&&&&&%%%%%###############%%%%%&&&&&&&&&&&
(((((((((((((((((((((((((((((((((#####(//*///*///**//(/***/***(//*(@@@@@@@&%%%########%%%%%%&&&&&@@@@@@@@@@@@&&&&&&%%%%%##############%%%%&&&&&&&&&%%%
((((((((((((((((((((((((((((((((((((((//((///(/#%%%(/////***///(&@@@@@@@@@@@(############%%%%&&&&&@@@@@@@@@@@@&&&&&&%%%%%##############%%%&&&&&&&&&&%%
(((((((((((((((((((((((((((((((((((((((#(////#%%###%#%%%#/*////*@@@@@@@@@@@&%#((#(#########%%%%&&&&@@@@@@@@@@@@@&&&&&&%%%%#############%%%%%&&&&%&&&%%
(/////////////((//((/(((((((/(((/(((/(((###(##(/*/(((///#((((((&@@@@@@@&&&&%&((((((((((((####%%%&&&&@@@@@@@@@@@@@@&&&&%%%%%##############%%%%%%%%%%%%%
((////////////////////////////////////@@@%%#%%###%%%((((%####(#@@@@@&&&%&&&%&&((((((((((((####%%%&&&@@@@@@@@@@@@@&&&&%%%%#######(##########%%%%%%%%%%%
(((///////////////////////////////////(@@@@&&%#((#%%#(###%&&%&@@@@&&&&@&&&&&##(((((((((((((####%%&&&@@@@@@@@@@@@&&&%%%%######(((((((((((#############%
(((((/////////////////////////////////&@@@@@@@&##%&&@%&%&&@@@@@@@@@@@@@&&%&#&&((((((((((((((###%%%&&@@@@@@@@@@@@&&%%%%#####(((((((((((((((((##########
(((((((///////////////////////////////&@@@@@@@&&@@@@@@@@@@@@@@@@@@@@@@@@&&@@%%((///////((((((###%%&&&@@@@@@@@@@&&&%%%###(((((((((((((((((((((((((((###
#(((((((////////////////////////*(%&&&&&@@@@@@@@@@@@@@@@@@@@@@&&&&&&&@@@@@@@@%/((((((((((((((###%%%&&&@@@@@@@@&&&%%%###(((((((((((((((((((((((((((((((
#((((((//////////////////////(&&&&&&&&&@@&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&#((((((((((###%%%&&@@@@@@@@&&&%%###((((((((((/(((((((((((((((((((((
((((((////////////////////##&&&&&&&&&&&&@@@@@&@@@@@@@&&@@@@@@@@@@@@@@@@@@@@@@@&@@@&&%#(//(((((####%%%&&&&&&&&&&%%%####((((////////((((((((((((((((((((
(((((///////////////////%%&&&&&&&&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&&&@&&@(%((((((((####%%%%%%%%%%%%####(((((/////////////////////////////
((/////////////////////&%&&&&&&&&&&&&%&&&@&@&@@@&&&@@&&@@@@@@@@@@@&@@@@@&@&&&&&&&&@&&@&%%#((((((((((##############(((((///////////////////////////////
//////////////////////&&&&&&&@&&&&&&&&&@&@&&&&@@@@@@@@@@@@&&@@&&&&&&&&&@&&&&&&&&&&@&&@&&&&##(#///((((((((((((((((((///////////////////////////////////
//////////*******////&&&&&&&&&&&&&&@&@@&&&&&&@@&@@@@@&@&@@@&&&&&&&&&&&&&&@&&@&&&&&@&@@&&&&&%#(((//////////////////////////////////////////////////////
////////*******/*///#@@&&&&&&&&&&&&&&&@&&&&&@@@@@@@@@@@&&&&&&&&&&&&&&&&@&&&&&&&&&@@@@@&&&&&&%#((#/////////////////////////////////////////////////////
////////////////////@@&&&&&&&&&&&&&&&&@&&&&&&@@@@@@@@&&@&&&&&&&&&&&&&&&&@&&&&&&@&@@@@@&&&&&&&%#(/(////////////////////////////////////////////////////
///////////////////(@@&&&&@&&&&&&&&&&&@@&&@&&@&&@@&&&&&&&&@&&&&&&&&&&@&@@&&&&&@@@@@@@@@&&&&&&&%##(////////////////////////////////////////////////////
///////////////////&&@&&&@@@&&&&&&&&&&&&&&@&@@&@@@&&&@@@&&&@@@&&&&&&&&&@@@@@&@@@&@@@@@@@@&@&@@&%%###////////////////////(((((((((((((/////////((((((((
///(/////////////((&@@@&&&&&&&&&&&&&&&&&&&&&@@@@@&&&@&&*,&.*,  .. *%@@&&@&&&&@@@@@@@@&@@&&@@@&&&%#((((((((((((((/((((((((((#######((((((((((((((((((((
((((((///////////(#&@@@&&&&@&&&&&&&&&&@&@&&@@@@@@@@&&&&&&&@&&&@@&&@#@@@@@@&@@@@@@@@@@&@@@@@@&&&&&%%#(((((((((((((((((((((############(((((((((((((((((";
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(man);
        Thread.Sleep(2000);
        Central_text("the man was not local", 2, 3000);
        Central_text("it was given out by other sounds from the mouth", 2, 4000);
        Central_text("but even so the butterfly understood the meaning of his speech", 2, 5000);
        Central_text("she saw a strange thing", 2, 3000);
        Central_text("print on the T-shirt was absolutely native...", 2, 4000);
        Central_text("city Odesa", 2, 4000);
        Second_flashbacks_animation();
    }

    //bruh
    static void Second_flashbacks_animation()
    {
        string o = @"((((((((((//////////////****************/%##%%%%##%%%%%%%%%%%##(///((/**/(((((#(((#%%%%%%%%%&&%%%&&%&&&&&&&&&&&&&&%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
%(((((((((((((////////////*************//(#%%%%#%%%%%%%%%%%%%%(/********////(((((###%%%%%%%&&&%&&&&&&%&%&&&%%&&&&%%%%%%%&&&&&&&&&&&&&&&%&&&&&&&&&&&&&&
((((((((((((((((////////////*****,****///(##%%%#%%%%%%#%%%%#((/****//****//(####((##@@%%%%%%&&%%%&%%%%%%%%%#%%%%%#%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
((((((((((((((((((((///////**********//#####%%%%%%%%####(####(/***///****//(##%%%%%%%%%%&%%%%%%%%%%%%%#(((((///((##%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
#((((((((((((((((((((((((///*******/////(#%###%%%%%#%#####%%##(//&((*****/(##%%%%##%%%%%%%%%%%%%%%#((#((///*////(((#%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
###(((((((((((((((((((((/////****/********///(##(#(((###%%%%%&&%%##(/**//////(%#%%#%#%%%%%%%%%%%%#/*********//(##(#((#%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&
####(((((((((((%&((((((//////****///**********/*////((#(####%#%#(((((//////////(((##%#%%%%%%%%%%%#//****,*****/((/(/(((%%%%%####%&%%%&&&&&&&&&&&&&&&&&
#######((((((((((((((((////////***//**********///***/////(########(/**///*/////////(#%#%%%%%%%%%%(/******,*****/////(#(###(//(##%%%%%%%&&&&&&&&&&&&&&&
#######((((((((((((((((&(/////*****/&******************/((((#(((#(((##(((#(((((((((((##@&&%%%%%%(//***********//////(%#%%(//(##(##%%%%%%%%%&%%&%%&&&&&
#######((((((((((((((((((//////***********************//(((((((//***//////////(((((((##%%#%%%%%%/**********//////(((#####(#(##((#%%%%%%%%%%%%%%%%%%%%%
##########((((((((((&(((((///////****//***************///(((((//*************////((((((#%%%%%%%(/*********/////((#%%%%(((((/(((#%%%%%%%%%%%%%%%%%%%%%%
(#######(((((((((((((((((((((///////////%***///////*////////////**/*/%*********///(((((##%%%%%%#((%##/////////(##%#((/(((((((((#%%%%%%%%%%%%%%%%%%%%%%
######(((((((((((((((((((((((///////////////////////////////**********,,,,*****//((((((%%#%%%%%%%%%((#(//////(((((((((///((((((#%%%%%%%%%%%%%%%%%%%%%%
##########(####(((((((((((((((////////////////////////////////*******,,,,******////(((######%%%%%%(//#(///////((((((///////((((##%%%%%%%%%%%%%%%%%%%%%
################((((((((((((((((///////////(((((//////////////*******,,,********////(((##%%#%%%%%#**********////((/(((((((((((((#%%%%%%%%%%%%%%%%%%%%%
################(((((((((((((((((((/((/(*/*(/,%#*%(///////////*****,,,,,/(,,*****////(((((##%%%#///*********///////(((((####(((#%%%%%%%%%%%%%%%%%%%%%%
################(#(((((((((((((((((,,((%(/%#.*/((%%//////////*/********,,,*******///////(((((##/*****/*********////((((((((((###%%%%%%%%%%%%%%%%%%%%%%
#############((((((#(((((((,((((%**,(,,,(/(%(/,*%%%%%&///////*******%***********//////((((/////**************///////(((((((((((##%%%%%%%%%%%%%%%%%%%%%
###############((((((((//%,#,(*,,,,/*,,#%&&&%%/%%%%%%%%%////%///////**********////////(((//////************//////((((((((((#(((((###%%%%%%%%%%%%%%%%%%
(###############(((((*(,#(,,,,,,,,,&#/**,,%%%&&&&&#&%%%%%&%///////////////////////////((((((#(/*********&*/////((((#((((###%##########%%%%%%%%%%%%%%%%
(((################(%###%%/.,#(*./#%**(,.,#&%%%%%#%&%#&%%%%///////*////////((////(((((((((##(((/////////////((((((#########%%#####%%%%%%%%%%%%%%%%%%%%
(((((#((((#(((#*,%(&&(&%%#%%#%#/*##,#(%&.*&&&#%%%%%%#%@%%&#//////////////((((((((((((((((#(#((((/////////(((((((#######%%%##(((###%%%%%%%%%%%%%%%%%%%%
#######((((((((((,,,,#%%&%/#(/*%..##.,((,/%%%%(#&&##%%%#&@%%#((((/////(((((#(((((((((((((((///*//////#((((((((#(((##((######((####%%%%%%%%%%%%%%%%%%%%
################,,%/(%%(*((%%%&%%&&%.*#.,#%#*.######&%#&%%%@@&(((/#(((((**/*//(((((/*((((((//,(//////((((((((###(((((##########################%%##%%%
################.*%,/#&%(,%&%&&&&&&.,((,*#%%#,##&@&&&%#&&#&&%%/,..(/,,,****,****/**...#*((*#/,,%(((((((((((((((((((###############%###################
###############/,(.*#%#,%&%%&&&&&&%,*(.,(%#//##%&&&&&&%#%%@&&##.(%%#*****,,,,,,,,,,##%/%%(%#(/*,*&#**.,(*#,#/%(#######################################
###############,/,,(#%*#%@&%&&&&&&,,(#.,#%#/,##@&&&&&&&#%%@%%%%#,/%%%(,,,,,,,,,,,,,,/((((/****,/%%###%&&%(#(*##%*,#*(%###*(###########################
%#############,*(,/#%#*%%%##/&&&&#,*(.,/#%%#*##&&%%&&%%%##%#%&%*,(#,#*&%%%%/%####(/&,..%*&&,*,*(*(/#(/***(#/**#%%%&%%/%%/#//*(########################
%%###########,,(.*#%#,%%&&###/%&#.,/%,,%%%*,##%%%&&&&%%%##%%%&*,,((#.*.,,%####.,..,/*..*/***(,,,%.#/,#%**/(,%&&&&#/*##%%%&&#(%&#######################
#%%#%#######,,/.,(#%%%%%#%##*(%%#,,(,,*#%#(.##/*,%%&%%%##%%#%*,,,(((.***&,,*//#//.,(,,.(**/**,,,*,(*&&&%(,,.,(&&%**.,%&&%#/%(%%@%##(,*################
&###########,*/,/#%#*%%&(//(###(.,/%/*#%%#(*##.//%%&&%%##&%##/.,,#(#./&*%**#/,#.%..(,..**%##(..,/(,%@&&@*,,,.#&@%,**.*&&%*./,,&&&/.*#*,,##############
&%%#######%,*(,*#%#/%%/%#%#((#*,,,,,,###%((%%#,/(%&&%%%##&%%#*/,,(((./%,(/*,,,..(../,.,,(//**..,,%*#&&&&*,...,@@@/%(..&%#/#.*/*((%#,,,*%##############
%&%%&#%%%&/((,#%%&%/%%**(/*,*...,,,##&###/.###%##%&&%%%##&%#%*,,,#(/./%,#.#.#.../..*,...,(//,,.,,*.#/@%&@,,/..(&&.,,..,@#((.,,.%%&%#,*,,(((((#(#(#(#(#
&&&%%%%%,,,,,*####,(/,/,(..,,(%%##(/%%&&%%/%%%&#####%%%%%&%#%*.,*##*./%*#,,.,..**..*(*,,/#/(((/,,*/*/@%%@.,,,.,&&&,,*..@#*.,.#,*#,%%%/,,,(((((((((((((
&&&%%&%,#%(/###&#,(##(**,,/#,,,**,..#%%&&%%%%%&%##%%##%#%&%%/,,,.##(*/...,,/,,,..,,,**//((///*,,,,**/,//(*,,,/.(,&/(#/(,@#,*.,,*/*(%%,,,,*((((((((((((
%#%#(%(/***,%%%%&%*,,,*(*,,//*(#/**%&&&&%*%%%##%%%%%&%%##%%*,,.*#%##.,..,,**////(((#%%######%%%%%%%&%/*,*//(#%%#%%&#(*%(***/.*(,*&.%%,,*,,((((((((((((
&%#%&,,/(//&%%%#%****(*/(#*///*/***&&&&&%(&%%&%%%&%##%%#%&%#,,,**#%(,,,,,***********,,....,,,,.,,,,%*/******/*******/(%%%%&&%#%%&#&*%#*,,,,(((((((((((
&&&&////##(&&%&%/#/,&%&&&%/*//(#/*/&&&&%*%%&&%##%&#%&%&&&&%%**/**%&((/**@&%%%%@&,(*******/**//*/(*////,@@@&&&,(##(%&&&&&&/(/*##/%*(&&%,,,,*(((((((((((
&%&#//////&&%%%**,%&&&&&&&/****/*/&&&&&%&@&&%@@@@&&#%&&&&&%&&*///&&///,*@%&((#(,.&*********&%%.***/#%/#*@@@%#/,*((,@&%&,,///&@%,((/%#%%*,,,,,(((((((((
@@(//((//&&&&&#*&%&&&&&@@/**%(//((&&&&@%@&%&&@@@@@&%#&&&&&%&%,***%%***.,@#(#(((%.%(((/*****((,,****/&##,&@@,,*.((//#&/,(.///&@&,((//%/%&/(/***,//***,/
@@//((//%&&&&%,%&&&&%/#&@#((*%//*&&&&@&%@@&%@@@@@@&&#&&&@&%&@%***%%***.,@((##/#%.(/****/////(/*,(((((/*,&&@,,,.,*//,@%*/.,*/(##,,/(/(%#&&%***/###/**,,
%%##%(//&&&&&//&&&&&/(*(,(#@&&/*/&&&&&%*&&&&&@@@@@&&&@&&&&&&#((/*&&(//.,&#%#(%#&./**************(**/((*#*%%%,,*.#//(%%(,/.#//#&*./(**%&&&&#&&&#*,*&&%";
        Central_text("she became very ill", 2, 1000);
        Console.WindowWidth = 150;
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(o);
        Thread.Sleep(2000);
        Cow_animation(30, 3);
        Central_text("again", 2, 1000);
        Family_animation(30, 1);
        Central_text("no...", 2, 1000);
        Cow_animation(30, 1);
        Beach();
    }
    static void Beach()
    {
        Central_text("and small butterfly was lying on sand...", 2, 3000);
        if(Click_to("Click 'S' very fast to stand up",30,"#",'s'))
        {
            Beach_second();
        }

    }
    static bool Click_to(string text, int times, string progress, char key)
    {
        int repeats = 0;
        bool end = false;
        Up_text(text, 3);
        while(end == false)
        {
            if (repeats == times)
            {
                end = true;
            }
            else if (Console.ReadKey().KeyChar == key)
            {
                repeats++;
                progress += "#";
            }
            Up_text(progress, 3);
        }
        return true;
        
    }

    static void Beach_second()
    {
        Central_text("this inscription remained in the head of the butterfly for another two years", 2, 7000);
        Central_text("she returned to her usual activities: the search for water and food", 2, 7000);
        Central_text("but people appeared on her untouched lawn...", 2, 3000);
        Humans_in_forest();
    }
    static void Humans_in_forest()
    {
        Central_text("CHAPTER 4: FOREST SONG", 1, 5000);
        Central_text("coming soon", 1, 5000);
        Fail();
    }
    static void Fail()
    {
        Central_text("thanks for being butterfly...", 2, 3000);
        Central_text("when it all ends", 2, 3000);
        Thread.Sleep(3000);
        Up_text("a - exit / b - start again");
        string yu = Console.ReadLine();
        if(yu == "a")
        {
            Central_text("bye", 2, 22000);
        }
        else if (yu == "b")
        {
            Main();
        }
    }
}
