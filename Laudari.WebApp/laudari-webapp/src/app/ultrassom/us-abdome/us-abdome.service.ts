import { Injectable } from '@angular/core';
import { ApiService } from '../../core/services/api.service';
import { map } from 'rxjs/operators';
import { Observable , } from 'rxjs';
@Injectable({providedIn: 'root' })
export class UsAbdomeService {


  constructor(private apiService: ApiService) { }


  gerar(objeto: Object): Observable<Object> {
    
    return this.apiService.post('/usabdome', objeto).pipe(map(
      data => {
        return data;
      }));
  }

}
