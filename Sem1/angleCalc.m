% 3 points
A = [0.5, 0.3, 0.6];
B = [0.5, 0.2, 0.3];
C = [0.4, 0, 0.1];

% vectors BA/BC - take A/C away from middle vector B
vec_1 = B - A;
vec_2 = B - C;

% calculate norm (Euclidean len) of the cross product and dot product of BA
%and BC. Inverse this using atan2d (four-quadrant inverse tangent)
angle = atan2d(norm(cross(vec_1,vec_2)),dot(vec_1,vec_2));

% print angle
disp(angle);
