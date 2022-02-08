import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AppConstants } from '../constants';

@Injectable({
  providedIn: 'root'
})
export class ResourceService {

constructor(private http:HttpClient) {}

  public GetAllResources = () => {
    return this.http.get(AppConstants.baseUrl);
  }

  public GetResourceBookings = (id:number) => {
    return this.http.get(AppConstants.baseUrl+AppConstants.getResourceBookings+id);
  }
}
