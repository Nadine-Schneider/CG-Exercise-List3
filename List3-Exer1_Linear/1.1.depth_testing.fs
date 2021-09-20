#version 330 core
out vec4 FragColor;

float near = 0.1; 
float far  = 100.0; 
  
void main()
{             
    float z = gl_FragCoord.z * 2.0 - 1.0; 
    float depth = ((2.0 * near * far) / (far + near - z * (far - near))) / far; // divide by far for demonstration
    FragColor = vec4(vec3(depth), 1.0);
}