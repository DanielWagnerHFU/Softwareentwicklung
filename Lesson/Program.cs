Vertex[] myVertices = new Vertex[100_000];
Random rand = new Random();

for(int i = 0; i < myVertices.Length; i++){
    myVertices[i] = new Vertex{
        Position = new Vec3D{
            x = rand.NextSingle(),
            y = rand.NextSingle(),
            z = rand.NextSingle()
        },
        Normal = new Vec3D{
            x = rand.NextSingle(),
            y = rand.NextSingle(),
            z = rand.NextSingle()
        },
        TexCoord = new Vec2D{
            x = rand.NextSingle(),
            y = rand.NextSingle()
        }
    };
}

public class Vertex
{
    public Vec3D Position;
    public Vec3D Normal;
    public Vec2D TexCoord;
}

public class Vec3D
{
    public float x;
    public float y;
    public float z;
}

public class Vec2D
{
    public float x;
    public float y;
}
