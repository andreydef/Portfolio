import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Stats } from '../../Models/Stats';

@Injectable()
export class StatsService {

  private url = 'api/stats';

  constructor(private http: HttpClient) { }

  getStats() {
    return this.http.get(this.url);
  }

  getStat(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  updateStats(stats: Stats) {
    return this.http.put(this.url, stats);
  }
}
