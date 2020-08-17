import { Photo } from "./photo";

export interface User {
    id: number;
    username: string;
    gender: string;
    lastActive: Date;
    knownAs: string;
    age: number;
    city: string;
    photoUrl: string;
    photos?: Photo[];
}
