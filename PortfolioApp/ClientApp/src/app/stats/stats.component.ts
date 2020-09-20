import { Component, OnInit } from '@angular/core';
import { Stats } from '../Models/Stats';
import { StatsService } from '../Services/stats/stats.service';

@Component({
  selector: 'app-stats',
  templateUrl: './stats.component.html',
  styleUrls: ['./stats.component.css'],
  providers: [ StatsService ]
})
export class StatsComponent implements OnInit {

  stat: Stats = new Stats();
  stats: Stats[];

  constructor(private statsService: StatsService) { }

  loadStats() {
    this.statsService.getStats()
      .subscribe((data: Stats[]) => this.stats = data);
  }

  ngOnInit() {
    this.loadStats();
  }
}
