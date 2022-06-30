
import { Hall } from "../Enums/Hall";
import { Time } from "../Enums/Day";

export class CreateClassDto
{
  ClassId: string;
  TeacherId: string;
  Location: number;
  Day: number;
  StudentsList: string[]
}
