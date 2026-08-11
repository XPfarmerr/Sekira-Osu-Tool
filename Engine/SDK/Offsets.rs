pub struct EntityOffsets {
    pub local_player: usize,
    pub entity_list: usize,
    pub health: usize,
    pub team_id: usize,
    pub position: usize,
}

impl Default for EntityOffsets {
    fn default() -> Self {
        Self {
            local_player: 0x18C334,
            entity_list: 0x20F120,
            health: 0x100,
            team_id: 0x104,
            position: 0x138,
        }
    }
}
