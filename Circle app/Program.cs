using System;

namespace Shapes_App
{
    class Program
    {
       
        static void Main(string[] args)
        {
            char selection;
            string Username;

            Console.WriteLine("**************************************************\nWelcome To Shapes Mesuring Program\n**************************************************\n");
            Console.Write("Enter Your Name: ");
            Username = Console.ReadLine();

            do
            {
                int selectingnum;
                int x, recwidth, reclength,Cuboidlength,Cuboidheight,Cuboidwidth;
                int Cylinderradius, Cylinderheight, Sphereradius, Cubelength, Pyramidlength, Pyramidheight;
                double Coneheight, Coneradius,PyramidSlantHeight;


               
                Console.WriteLine("\nEnter Desired Mesuring aspect by given number(1-8)?");
                Console.WriteLine("\n1.Circle\n2.Rectangle\n3.Cone\n4.Cuboid\n5.Cylinder\n6.Sphere\n7.Cube\n8.Pyramid\n");
                
                selectingnum = Convert.ToInt32(Console.ReadLine());

                switch (selectingnum)
                {
                    case 1:

                        Circle cn = new Circle();
                        Console.Write("\nEnter circle Radius : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        cn.Setradius(x);

                        float cir = cn.CalculateCircumference();
                        float Ar = cn.CalculateArea();

                        Console.WriteLine("\nDear {0} Data fetched Successfully !!!!\n****************************************************",Username);
                        Console.WriteLine("Circumference is: " + cir);
                        Console.WriteLine("Area is: " + Ar);
                        Console.WriteLine("\n****************************************************\nEnd of the program");

                        break;

                    case 2:
                        Rectangle rn = new Rectangle();
                        Console.Write("\nEnter Rectangle length : ");
                        reclength = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Rectangle width : ");
                        recwidth = Convert.ToInt32(Console.ReadLine());
                        
                        rn.Setvalues(reclength, recwidth);

                        float rectanglecir = rn.CalculateCircumference();
                        float rectanglearea = rn.CalculateArea();

                        Console.WriteLine("\nDear {0} Data fetched Successfully !!!!\n****************************************************", Username);
                        Console.WriteLine("Circumference for Rectangle is : " + rectanglecir);
                        Console.WriteLine("Area for Rectangle is : " + rectanglearea);
                        Console.WriteLine("\n****************************************************\nEnd of the program");

                        break;

                    case 3:
                        cone cc = new cone();
                        Console.Write("\nEnter Cone height: ");
                        Coneheight = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Cone Radius: ");
                        Coneradius = Convert.ToDouble(Console.ReadLine());

                        cc.height = Coneheight;
                        cc.radius = Coneradius;

                        double Conesurfacearea = cc.Calculatesurface();
                        double Conevolume = cc.Calculatevolume();

                        Console.WriteLine("\nDear {0} Data fetched Successfully !!!!\n****************************************************", Username);
                        Console.WriteLine("Surface area for Cone is : " + Conesurfacearea);
                        Console.WriteLine("Volume for Cone is : " + Conevolume);
                        Console.WriteLine("\n****************************************************\nEnd of the program");

                        break;

                    case 4:
                        Cuboid cb = new Cuboid();
                        Console.Write("\nEnter Cuboid length: ");
                        Cuboidlength = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Cuboid width: ");
                        Cuboidwidth = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Cuboid height: ");
                        Cuboidheight = Convert.ToInt32(Console.ReadLine());

                        cb.cuboidlength = Cuboidlength;
                        cb.cuboidwidth = Cuboidwidth;
                        cb.cuboidheight = Cuboidheight;

                        int Cuboidsurface = cb.Calculatecuboidsurface();
                        int Cuboidvolume = cb.Calculatecuboidvolume();

                        Console.WriteLine("\nDear {0} Data fetched Successfully !!!!\n****************************************************", Username);
                        Console.WriteLine("Surface area for cuboid is : " + Cuboidsurface);
                        Console.WriteLine("Volume for cuboid is : " + Cuboidvolume);
                        Console.WriteLine("\n****************************************************\nEnd of the program");

                        break;
                    case 5:
                        Cylinder cl = new Cylinder();
                        Console.Write("\nEnter Cylinder Radius: ");
                        Cylinderradius = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Cylinder Height: ");
                        Cylinderheight = Convert.ToInt32(Console.ReadLine());

                        cl.Radius = Cylinderradius;
                        cl.Height = Cylinderheight;

                        float Cylinderarea = cl.CylinderArea();
                        float Cylindervolume = cl.CylinderVolume();

                        Console.WriteLine("\nDear {0} Data fetched Successfully !!!!\n****************************************************", Username);
                        Console.WriteLine("Area for cylinder is : " + Cylinderarea);
                        Console.WriteLine("Volume for cylinder is : " + Cylindervolume);
                        Console.WriteLine("\n****************************************************\nEnd of the program");

                        break;
                    case 6:
                        Sphere sp = new Sphere();
                        Console.Write("\nEnter sphere Radius: ");
                        Sphereradius = Convert.ToInt32(Console.ReadLine());

                        sp.Radius = Sphereradius;

                        float spherearea = sp.SphereArea();
                        float spherevolume = sp.SphereVolume();

                        Console.WriteLine("\nDear {0} Data fetched Successfully !!!!\n****************************************************", Username);
                        Console.WriteLine("Area for sphere is : " + spherearea);
                        Console.WriteLine("Volume for sphere is : " + spherevolume);
                        Console.WriteLine("\n****************************************************\nEnd of the program");

                        break;
                    case 7:
                        Cube cu = new Cube();
                        Console.Write("\nEnter cube length: ");
                        Cubelength = Convert.ToInt32(Console.ReadLine());
                        
                        cu.Lenght = Cubelength;

                        double Cubearea = cu.AreaofCube();
                        double Cubevolume = cu.volumeOfCube();

                        Console.WriteLine("\nDear {0} Data fetched Successfully !!!!\n****************************************************", Username);
                        Console.WriteLine("Area of the cube is: {0}",Cubearea);
                        Console.WriteLine("Volume of the cube is: {0}", Cubevolume);
                        Console.WriteLine("\n****************************************************\nEnd of the program");

                        break;
                    case 8:
                        Pyramid pr = new Pyramid();
                        Console.Write("\nEnter pyramid length: ");
                        Pyramidlength = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter pyramid height: ");
                        Pyramidheight = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter pyramid slantheight: ");
                        PyramidSlantHeight = Convert.ToDouble(Console.ReadLine());

                        pr.Lenght = Pyramidlength;
                        pr.Height = Pyramidheight;
                        pr.SlantHeight = PyramidSlantHeight;

                        double Pyramidarea = pr.areaOfPyramid();
                        double Pyramidvolume = pr.volumeOfPyramid();

                        Console.WriteLine("\nDear {0} Data fetched Successfully !!!!\n****************************************************", Username);
                        Console.WriteLine("Area of the pyramid is: {0}", Pyramidarea);
                        Console.WriteLine("Volume of the pyramid is: {0}", Pyramidvolume);
                        Console.WriteLine("\n****************************************************\nEnd of the program");

                        break;
                    default:
                        Console.WriteLine("Invalid Number Try Again");
                        break;

                }
               
                    Console.WriteLine("Are you need more mesurements y/n?");    
                    selection = Convert.ToChar(Console.ReadLine());    
                } while (selection == 'y') ; 
            
            Console.WriteLine("End Of The Session See Next time !!!!!");

            Console.ReadLine();

        }
    }
}
