import { IPropertyBase } from './ipropertybase';

export class Property implements IPropertyBase {
  Id: number;
  SellRent: number;
  Name: string;
  FType: string;
  PType: string;
  Price: number;
  BHK: number;
  BuiltArea: number;
  CarpetArea?: number;
  Address: string;
  Address2?: string;
  City: string;
  FloorNo?: string;
  TotalFloors?: string;
  RTM: number;
  AOP?: string;
  MainEntrance?: string;
  Security?: number;
  Gated?: number;
  Maintenance?: number;
  Possession?: string;
  Image?: string;
  Description?: string;
  PostedOn: string;
  PostedBy: number;
}
