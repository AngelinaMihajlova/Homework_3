// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
// AB = √ (Xb-Xa)2 + (Yb-Ya)2 + (Zb-Za)2

double FindDistance (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = 0;

    distance = Math.Sqrt (Math.Pow (x2 - x1, 2) + Math.Pow (y2 - y1, 2) + Math.Pow (z2 - z1, 2));
    return distance;
}

FindDistance (x1 = 3, y1 = 6, z1 = 8, x2 = 2, y2 = 1, x2 = -7);
